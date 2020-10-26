using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodIt.Foodit.dtos
{
    public class Recipe
    {
        private string recipeId;
        private string email;
        private string title;
        private string description;
        private string status;
        private DateTime date;
        private string image;
        private string category;

        public string RecipeId { get => recipeId; set => recipeId = value; }
        public string Email { get => email; set => email = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Status { get => status; set => status = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Image { get => image; set => image = value; }
        public string Category { get => category; set => category = value; }

        public Recipe(string recipeId, string email, string title, 
            string description, string status, DateTime date, 
            string image, string category)
        {
            RecipeId = recipeId;
            Email = email;
            Title = title;
            Description = description;
            Status = status;
            Date = date;
            Image = image;
            Category = category;
        }

        public Recipe(string recipeId, string title, 
            DateTime date, string image, string category)
        {
            RecipeId = recipeId;
            Title = title;
            Date = date;
            Image = image;
            Category = category;
        }

        public Recipe()
        {
            RecipeId = recipeId;
            Title = "";
            Image = "";
            Category = "";
        }
    }
}
