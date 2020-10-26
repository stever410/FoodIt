using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodIt.FoodIt.dtos
{
    public class Recipe
    {
        public const string DEFAULT_STATUS = "active";
        private int id;
        private string email;
        private string title;
        private string description;
        private string status;
        private DateTime date;
        private string image;
        private List<RecipeIngredient> recipeIngredients;
        private List<RecipeStep> recipeSteps;
        private List<Ingredient> ingredients;

        public Recipe(string title, DateTime date, string image)
        {
            this.title = title;
            this.date = date;
            this.image = image;
        }

        public Recipe(string email, string title, string description, string status, DateTime date, string image)
        {
            this.email = email;
            this.title = title;
            this.description = description;
            this.status = status;
            this.date = date;
            this.image = image;
        }

        public Recipe(int id, string email, string title, string description, string status, DateTime date, string image)
        {
            this.Id = id;
            this.Email = email;
            this.Title = title;
            this.Description = description;
            this.Status = status;
            this.Date = date;
            this.Image = image;
        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Status { get => status; set => status = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Image { get => image; set => image = value; }
        public List<RecipeIngredient> RecipeIngredients { get => recipeIngredients; set => recipeIngredients = value; }
        public List<RecipeStep> RecipeSteps { get => recipeSteps; set => recipeSteps = value; }
        public List<Ingredient> Ingredients { get => ingredients; set => ingredients = value; }
    }
}
