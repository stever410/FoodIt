using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodIt.dtos
{
    public class RecipeStep
    {
        private int id;
        private int recipeID;
        private string description;

        public RecipeStep(int id, string description)
        {
            this.id = id;
            this.description = description;
        }

        public RecipeStep(int id, int recipeID, string description)
        {
            this.Id = id;
            this.RecipeID = recipeID;
            this.Description = description;
        }

        public int Id { get => id; set => id = value; }
        public int RecipeID { get => recipeID; set => recipeID = value; }
        public string Description { get => description; set => description = value; }

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
