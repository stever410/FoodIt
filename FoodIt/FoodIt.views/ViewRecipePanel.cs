﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodIt.FoodIt.dtos;
using System.IO;
using FoodIt.FoodIt.daos;
using Guna.UI2.WinForms;

namespace FoodIt.FoodIt.views
{
    public partial class ViewRecipePanel : UserControl
    {
        private Recipe recipe;
        public ViewRecipePanel(Recipe recipe)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            this.recipe = recipe;
            this.lblTitle.Text = recipe.Title;

            string imgage = recipe.Image.Substring(recipe.Image.LastIndexOf('/') + 1);

            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;

            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            String path = projectDirectory + @"\resources\img\" + imgage;
            this.imgRecipe.ImageLocation = path;

            // generate a guna html label
            Guna2HtmlLabel lblDetails = new Guna2HtmlLabel();
            lblDetails.Font = new Font("Segoe UI", 16);

            // get all ingredients and render on view
            IngredientDAO dao = new IngredientDAO();
            this.recipe.Ingredients = dao.GetAllIngredientsByRecipe(recipe);
            lblDetails.Text = "<h3>Ingredients</h3>" + RenderIngredients();

            // get all steps and render on view
            this.recipe.RecipeSteps = RecipeStepDAO.GetRecipeStepsByRecipe(recipe);
            lblDetails.Text += "<h3>Steps</h3><div style='width: 800px;text-align: justify;'>" + RenderSteps() + "</div>";
            
            // add this to panel
            this.ingrePanel.Controls.Add(lblDetails);
        }

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
    }
}
