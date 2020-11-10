using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodIt.dtos
{
    public class RecipeIngredient
    {
        private int recipeID;
        private int ingredientID;
        private string amountIngredient;
        private string note;

        public RecipeIngredient(int ingredientID, string amountIngredient, string note)
        {
            this.ingredientID = ingredientID;
            this.amountIngredient = amountIngredient;
            this.note = note;
        }

        public RecipeIngredient(int recipeID, int ingredientID, string amountIngredient, string note)
        {
            this.RecipeID = recipeID;
            this.IngredientID = ingredientID;
            this.AmountIngredient = amountIngredient;
            this.Note = note;
        }

        public int RecipeID { get => recipeID; set => recipeID = value; }
        public int IngredientID { get => ingredientID; set => ingredientID = value; }
        public string AmountIngredient { get => amountIngredient; set => amountIngredient = value; }
        public string Note { get => note; set => note = value; }

        public override bool Equals(object obj)
        {
            return obj is RecipeIngredient ingredient &&
                   recipeID == ingredient.recipeID &&
                   ingredientID == ingredient.ingredientID;
        }

        public override int GetHashCode()
        {
            int hashCode = 1731783973;
            hashCode = hashCode * -1521134295 + recipeID.GetHashCode();
            hashCode = hashCode * -1521134295 + ingredientID.GetHashCode();
            return hashCode;
        }
    }
}
