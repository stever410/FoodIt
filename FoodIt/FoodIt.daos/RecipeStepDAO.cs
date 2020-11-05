using FoodIt.db;
using FoodIt.FoodIt.dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodIt.FoodIt.daos
{
    public class RecipeStepDAO
    {
        private static SqlConnection cnn;
        private static SqlCommand cmd;
        private static SqlDataReader reader;

        public static List<RecipeStep> GetRecipeStepsByRecipe(Recipe recipe)
        {
            List<RecipeStep> steps = null;
            try
            {
                string sql = @"SELECT step_id, [description], image 
                                FROM dbo.RecipeStep
                                WHERE recipe_id = @id";

                using(cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    using(cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", recipe.Id);
                        using(reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = (int)reader["step_id"];
                                string desc = reader["description"] as string;
                                string image = reader["image"] as string;
                                RecipeStep step = new RecipeStep(id, desc, image);
                                step.RecipeID = recipe.Id;

                                if (steps == null)
                                {
                                    steps = new List<RecipeStep>();
                                }
                                steps.Add(step);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return steps;
        }

        public bool AddRecipeSteps(int recipeID, List<RecipeStep> steps)
        {
            try
            {
                string sql = "Insert RecipeStep values(@recipe_id, @description, @image)";
                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    SqlTransaction transaction = cnn.BeginTransaction();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Transaction = transaction;
                        foreach (RecipeStep step in steps)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@recipe_id", recipeID);
                            cmd.Parameters.AddWithValue("@description", step.Description);
                            cmd.Parameters.AddWithValue("@image", step.Image);
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

        public bool DeleteRecipeSteps(int recipeID)
        {
            bool check = false;
            try
            {
                string sql = "DELETE FROM dbo.RecipeStep WHERE recipe_id = @id";
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

        public bool UpdateRecipeSteps(int recipeID, List<RecipeStep> steps)
        {
            bool check = false;
            try
            {
                // Update by delete then add new :)
                check = DeleteRecipeSteps(recipeID);
                check &= AddRecipeSteps(recipeID, steps);
            }
            catch (SqlException se)
            {
                throw se;
            }

            return check;
        }
    }
}
