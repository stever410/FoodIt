using System;
using System.Windows.Forms;
using FoodIt.dtos;
using System.IO;
using FoodIt.daos;
using Guna.UI2.WinForms;

namespace FoodIt.views
{
    public partial class ViewRecipePanel : UserControl
    {
        private Recipe recipe;
        private User user;
        private MainForm mainForm;
        public ViewRecipePanel(Recipe recipe, User user)
        {
            this.user = user;

            InitializeComponent();
            this.Dock = DockStyle.Fill;

            this.recipe = recipe;
            this.lblTitle.Text = recipe.Title;

            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            String path = projectDirectory + @"\resources\" + recipe.Image;
            this.imgRecipe.ImageLocation = path;

            // get all ingredients and render on view
            IngredientDAO ingredientDAO = new IngredientDAO();
            this.recipe.Ingredients = ingredientDAO.GetAllIngredientsByRecipe(recipe);
            lblDetails.Text = "<h3>Ingredients</h3>" + RenderIngredients();

            // get all steps and render on view
            RecipeStepDAO recipeStepDAO = new RecipeStepDAO();
            this.recipe.RecipeSteps = recipeStepDAO.GetRecipeStepsByRecipe(recipe);
            lblDetails.Text += "<h3>Steps</h3><div style='width: 780px;'>" + RenderSteps() + "</div>";

            // add update button
            if (!this.User.Email.Equals(recipe.Email))
            {
                controlPanel.Hide();
            }
        }

        public User User { get => user; set => user = value; }
        public MainForm MainForm { get => mainForm; set => mainForm = value; }

        public string RenderIngredients()
        {
            string result = "";
            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                result += "<div>- " + ingredient.Amount + " " + ingredient.Name + "</div>";
            }

            return result;
        }

        public string RenderSteps()
        {
            string result = "";
            foreach (RecipeStep step in recipe.RecipeSteps)
            {
                result += "<p>- " + step.Description + "</p>";
            }

            return result;
        }

        private void btnUpdateRecipe_Click(object sender, EventArgs e)
        {
            // create new update panel
            UpdateRecipePanel updateRecipePanel = new UpdateRecipePanel(this.User, this.recipe);

            // set the mainform to update panel
            MainForm mainForm = this.MainForm;
            updateRecipePanel.MainForm = mainForm;

            // render on view
            mainForm.RenderOnMainPanel(updateRecipePanel);
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            // ask if user really want to delete? if no return
            if (MessageBox.Show("Are you sure to delete " + recipe.Title + "? (This action cannot be undo)", 
                "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // yes then proceed delete
            try
            {
                RecipeDAO dao = new RecipeDAO();
                if(dao.DeleteRecipe(this.recipe))
                    MessageBox.Show("Deleted " + recipe.Id + "-" + recipe.Title);

                Guna2Panel mainPnl = this.Parent as Guna2Panel;
                mainPnl.Controls.Clear();
                FoodGridPanel foodGridPanel = new FoodGridPanel(mainPnl);
                foodGridPanel.User = this.User;
                mainPnl.Controls.Add(foodGridPanel);
                mainForm.SetHomeButton();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
