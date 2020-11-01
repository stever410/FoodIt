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
    }
}
