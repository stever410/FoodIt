using FoodIt.db;
using FoodIt.FoodIt.dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodIt.FoodIt.daos
{
    public class RecipeIngredientDAO
    {
        private static SqlConnection cnn;
        private static SqlCommand cmd;

        public bool AddRecipeIngredients(int recipeID, List<RecipeIngredient> recipeIngredients)
        {
            try
            {
                string sql = "Insert RecipeIngredient values(@recipe_id, @irgre_id, @amount_ingre, @note)";
                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    SqlTransaction transaction = cnn.BeginTransaction();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Transaction = transaction;
                        foreach (RecipeIngredient recipeIngredient in recipeIngredients)
                        {
                            cmd.Parameters.AddWithValue("@recipe_id", recipeID);
                            cmd.Parameters.AddWithValue("@irgre_id", recipeIngredient.IngredientID);
                            cmd.Parameters.AddWithValue("@amount_ingre", recipeIngredient.AmountIngredient);
                            cmd.Parameters.AddWithValue("@note", recipeIngredient.Note);
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        return true;
                    }
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }
    }
}
