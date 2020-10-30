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
    public class RecipeDAO
    {
        private static SqlConnection cnn;
        private static SqlCommand cmd;
        private static SqlDataReader reader;
        private static SqlDataAdapter da;

        public static List<Recipe> GetAllRecipes()
        {
            List<Recipe> list = null;

            String sql = "SELECT recipe_id, title, date, image " +
                "FROM Recipe WHERE status NOT LIKE 'deleted'";
            try
            {
                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        using(reader = cmd.ExecuteReader())
                        {
                            da = new SqlDataAdapter(cmd);
                            while (reader.Read())
                            {
                                int id = (int)reader["recipe_id"];
                                string title = reader["title"] as string;
                                DateTime date = reader.GetDateTime(2);
                                string image = reader["image"] as string;

                                Recipe recipe = new Recipe(title, date, image);
                                recipe.Id = id;

                                if (list == null)
                                {
                                    list = new List<Recipe>();
                                }

                                list.Add(recipe);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return list;
        }

        public int AddRecipe(Recipe recipe)
        {
            try
            {
                string sql = "Insert Recipe output INSERTED.recipe_id values(@email, @title, @description, @status, @date, @image, @category)";
                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@email", recipe.Email);
                        cmd.Parameters.AddWithValue("@title", recipe.Title);
                        cmd.Parameters.AddWithValue("@description", recipe.Description);
                        cmd.Parameters.AddWithValue("@status", recipe.Status);
                        cmd.Parameters.AddWithValue("@date", recipe.Date);
                        cmd.Parameters.AddWithValue("@image", recipe.Image);
                        cmd.Parameters.AddWithValue("@category", "");
                        //return cmd.ExecuteNonQuery() > 0;
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }

        //public int getIDRecipe()
        //{
        //    try
        //    {
        //        string sql = "Select recipe_id From R"
        //    }
        //    catch (SqlException se)
        //    {
        //        throw new Exception(se.Message);
        //    }
        //}
    }
}
