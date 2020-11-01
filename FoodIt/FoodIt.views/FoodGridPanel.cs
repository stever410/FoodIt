using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodIt.FoodIt.dtos;
using FoodIt.FoodIt.daos;
using Guna.UI2.WinForms;
using FoodIt.FoodIt.views;
using System.Globalization;

namespace FoodIt
{
    public partial class FoodGridPanel : UserControl
    {
        private const int INGREDIENT = 0;
        private const int RECIPE = 1;
        private const int ROWS = 4;
        private const int COLS = 4;
        private List<Recipe> recipes;
        private const int PAGE_SIZE = 16;
        private int totalRecords, totalPages;
        private int pageNo = 1;
        private Guna2Panel mainPnl;
        private List<string> searchIngredients; // all the ingredients the user input
        AutoCompleteStringCollection ingredientsAutoCompleteCollection;

        public FoodGridPanel(Guna2Panel mainPnl)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.mainPnl = mainPnl;
            searchIngredients = new List<string>();
            ingredientsAutoCompleteCollection = new AutoCompleteStringCollection();
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
            txtIngredient.AutoCompleteCustomSource = ingredientsAutoCompleteCollection;
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
                // this function will turn the first letter to Capitalized
                string ingredient = txtIngredient.Text.First().ToString().ToUpper() + txtIngredient.Text.Substring(1).ToLower();
                if (searchIngredients.Contains(ingredient))
                {
                    MessageBox.Show("Tag already exist");
                    return;
                }
                if(ingredientsAutoCompleteCollection.Contains(ingredient)) 
                {
                    // add the ingredient to the search list
                    searchIngredients.Add(ingredient);
                    IngredientTag tag = new IngredientTag(ingredient, searchIngredients);
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
