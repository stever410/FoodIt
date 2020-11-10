using FoodIt.db;
using FoodIt.dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodIt.daos
{
    public class RecipeIngredientDAO
    {
        private static SqlConnection cnn;
        private static SqlCommand cmd;
        private static SqlDataReader reader;

        public bool AddRecipeIngredients(int recipeID, List<RecipeIngredient> recipeIngredients)
        {
            try
            {
                string sql = "Insert RecipeIngredient values(@recipe_id, @ingre_id, @amount_ingre, @note)";
                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    SqlTransaction transaction = cnn.BeginTransaction();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Transaction = transaction;
                        
                        foreach (RecipeIngredient recipeIngredient in recipeIngredients)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@recipe_id", recipeID);
                            cmd.Parameters.AddWithValue("@ingre_id", recipeIngredient.IngredientID);
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

        public List<RecipeIngredient> GetRecipeIngredientsByRecipe(Recipe recipe)
        {
            List<RecipeIngredient> recipeIngredients = new List<RecipeIngredient>();
            try
            {
                string sql = @"  SELECT Ingredient.ingre_id, amount_ingre, note 
                                FROM dbo.Recipe, dbo.RecipeIngredient, dbo.Ingredient
                                WHERE Recipe.recipe_id = RecipeIngredient.recipe_id 
                                AND Ingredient.ingre_id = RecipeIngredient.ingre_id 
                                AND Recipe.recipe_id = @id";

                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", recipe.Id);
                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int ingreId = (int)reader["ingre_id"];
                                string note = reader["note"] as string;
                                string amount = reader["amount_ingre"] as string;

                                RecipeIngredient recipeIngredient = new RecipeIngredient(ingreId, amount, note);
                                recipeIngredient.RecipeID = recipe.Id;

                                recipeIngredients.Add(recipeIngredient);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return recipeIngredients;
        }

        public bool DeleteAllRecipeIngredients(int recipeID)
        {
            bool check = false;

            try
            {
                string sql = "DELETE FROM dbo.RecipeIngredient WHERE recipe_id = @id";
                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", recipeID);

                        check = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException se)
            {
                throw se;
            }

            return check;
        }

        public bool UpdateRecipeIngredients(int recipeID, List<RecipeIngredient> recipeIngredients)
        {
            bool check = false;

            try
            {
                check = DeleteAllRecipeIngredients(recipeID);
                check &= AddRecipeIngredients(recipeID, recipeIngredients);
            }
            catch (Exception e)
            {
                throw e;
                throw;
            }

            return check;
        }
    }
}
