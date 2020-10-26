using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodIt.FoodIt.dtos
{
    public class RecipeStep
    {
        private int id;
        private int recipeID;
        private string description;
        private string image;

        public RecipeStep(int id, string description, string image)
        {
            this.id = id;
            this.description = description;
            this.image = image;
        }

        public RecipeStep(int id, int recipeID, string description, string image)
        {
            this.Id = id;
            this.RecipeID = recipeID;
            this.Description = description;
            this.Image = image;
        }

        public int Id { get => id; set => id = value; }
        public int RecipeID { get => recipeID; set => recipeID = value; }
        public string Description { get => description; set => description = value; }
        public string Image { get => image; set => image = value; }

        public override bool Equals(object obj)
        {
            return obj is RecipeStep step &&
                   id == step.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + id.GetHashCode();
        }
    }
}
