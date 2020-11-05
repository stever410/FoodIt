using FoodIt.dtos;
using FoodIt.FoodIt.daos;
using FoodIt.FoodIt.dtos;
using FoodIt.FoodIt.views;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FoodIt
{
    public partial class FoodGridPanel : UserControl
    {
        private const int ROWS = 4;
        private const int COLS = 4;
        private List<Recipe> recipes;
        private const int PAGE_SIZE = 16;
        private int totalRecords, totalPages;
        private int pageNo = 1;
        private Guna2Panel mainPnl;
        private List<string> searchIngredients; // all the ingredients the user input
        private List<string> ingredientsAutoCompleteCollection;
        private User user;

        public User User { get => user; set => user = value; }

        public FoodGridPanel(Guna2Panel mainPnl)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.mainPnl = mainPnl;

            searchIngredients = new List<string>();
            ingredientsAutoCompleteCollection = new List<string>();
        }

        private void LoadFoodGrid()
        {
            // clear current page
            pnlMain.Controls.Clear();

            // init grid layout inside main panel
            pnlMain.RowCount = ROWS;
            pnlMain.ColumnCount = COLS;

            // get recipe based on pageNo
            int recipeNo = (pageNo - 1) * PAGE_SIZE;

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    FoodPanel foodPanel = new FoodPanel(recipes[recipeNo]);

                    // pass main panel
                    foodPanel.MainPnl = this.mainPnl;

                    // pass user
                    foodPanel.User = this.user;

                    pnlMain.Controls.Add(foodPanel, j, i);
                    recipeNo++;
                    // when exist total records just done
                    if (recipeNo >= recipes.Count)
                    {
                        return;
                    }
                }
            }
        }

        private void LoadIngredientsAutoComplete()
        {
            IngredientDAO dao = new IngredientDAO();
            List<Ingredient> ingredients = dao.GetAllIngredients();
            foreach (Ingredient ingredient in ingredients)
            {
                ingredientsAutoCompleteCollection.Add(ingredient.Name);
            }
            // add all ingredients to ingredients autocomplete array
            txtIngredient.AutoCompleteCustomSource.AddRange(ingredientsAutoCompleteCollection.ToArray());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageNo != totalPages)
            {
                ++pageNo;
            }
            else
            {
                pageNo = 1;
            }
            LoadFoodGrid();
            lblPaging.Text = pageNo + "/" + totalPages;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pageNo != 1)
            {
                --pageNo;
            }
            else
            {
                pageNo = totalPages;
            }
            LoadFoodGrid();
            lblPaging.Text = pageNo + "/" + totalPages;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                RecipeDAO dao = new RecipeDAO();
                recipes = dao.GetRecipesBySearch(txtSearch.Text);
                if(recipes.Count > 0)
                {
                    totalRecords = recipes.Count;
                    totalPages = (int)Math.Ceiling(totalRecords * 1.0 / PAGE_SIZE);
                    lblPaging.Text = pageNo + "/" + totalPages;
                    LoadFoodGrid();
                } else
                {
                    MessageBox.Show("No result found!");
                }
            }
        }

        private void txtIngredient_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(string.IsNullOrWhiteSpace(txtIngredient.Text))
                {
                    MessageBox.Show("Input ingredient first");
                    return;
                }
                string ingredientName = txtIngredient.Text;
                // check if the search ingredients list contain the ingredient 
                if (searchIngredients.Contains(ingredientName, StringComparer.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Tag already exist");
                    return;
                }
                // check if the ingredient exist (ignored case) in db
                int ingredientIdx = ingredientsAutoCompleteCollection.FindIndex(ingredient => ingredient.Equals(ingredientName, StringComparison.OrdinalIgnoreCase));
                if(ingredientIdx > -1) 
                {
                    //replace the ingredient name with the name in db
                    ingredientName = ingredientsAutoCompleteCollection[ingredientIdx];
                    // add the ingredient to the search list
                    searchIngredients.Add(ingredientName);
                    IngredientTag tag = new IngredientTag(ingredientName, searchIngredients);
                    // Add tag then empty text box
                    pnlIngredients.Controls.Add(tag);
                    txtIngredient.Text = string.Empty;
                } else
                {
                    MessageBox.Show("Ingredient must be select from autocomplete");
                }
            }
        }

        private void btnFindRecipeByIngredients_Click(object sender, EventArgs e)
        {
            try
            {
                if(searchIngredients.Count == 0)
                {
                    MessageBox.Show("No ingredients was selected");
                    return;
                }
                RecipeDAO dao = new RecipeDAO();
                List<Recipe> result = dao.GetRecipesByIngredients(searchIngredients);
                if (result.Count > 0)
                {
                    recipes = result;
                    totalRecords = recipes.Count;
                    totalPages = (int)Math.Ceiling(totalRecords * 1.0 / PAGE_SIZE);
                    lblPaging.Text = pageNo + "/" + totalPages;
                    LoadFoodGrid();
                } else
                {
                    MessageBox.Show("No recipes found!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FoodGridPanel_Load(object sender, EventArgs e)
        {
            RecipeDAO dao = new RecipeDAO();
            try 
            { 
                recipes = dao.GetAllRecipes();
                // paging steps
                totalRecords = recipes.Count;
                totalPages = (int)Math.Ceiling(totalRecords * 1.0 / PAGE_SIZE);
                lblPaging.Text = pageNo + "/" + totalPages;
                LoadFoodGrid();
                LoadIngredientsAutoComplete();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
