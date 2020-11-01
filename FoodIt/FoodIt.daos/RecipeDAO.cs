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
    public class RecipeDAO
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;

        public RecipeDAO()
        {
        }

        public List<Recipe> GetAllRecipes()
        {
            List<Recipe> list = null;
            string sql = "SELECT recipe_id, title, date, image " +
                "FROM Recipe WHERE status NOT LIKE 'deleted'";
            conn = MyConnection.GetMyConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                using (conn = MyConnection.GetMyConnection())
                {
                    conn.Open();
                    using (cmd = new SqlCommand(sql, conn))
                    {
                        using (reader = cmd.ExecuteReader())
                        {
                            Recipe recipe;
                            while (reader.Read())
                            {
                                int id = (int)reader["recipe_id"];
                                string title = reader["title"] as string;
                                DateTime date = reader.GetDateTime(2);
                                string image = reader["image"] as string;
                                recipe = new Recipe(id, title, date, image);
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
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return list;
        }

        public List<Recipe> GetRecipesBySearch(string search)
        {
            List<Recipe> list = null;
            string sql = "SELECT recipe_id, title, date, image " +
                        "FROM Recipe WHERE status NOT LIKE 'deleted' AND title LIKE @search";
            try
            {
                using (conn = MyConnection.GetMyConnection())
                {
                    conn.Open();
                    using (cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", search);
                        using (reader = cmd.ExecuteReader())
                        {
                            list = new List<Recipe>();
                            while (reader.Read())
                            {
                                int id = (int)reader["recipe_id"];
                                string title = reader["title"] as string;
                                DateTime date = reader.GetDateTime(2);
                                string image = reader["image"] as string;
                                Recipe recipe = new Recipe(id, title, date, image);
                                list.Add(recipe);
                            }
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return list;
        }

        public List<Recipe> GetRecipesByIngredients(List<string> ingredients)
        {
            List<Recipe> list = null;

            try
            {
                using (conn = MyConnection.GetMyConnection())
                {
                    conn.Open();
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        string[] parameters = new string[ingredients.Count];
                        int i = 0;
                        foreach (string ingredient in ingredients)
                        {
                            parameters[i] = string.Format("@Ingredient{0}", i);
                            cmd.Parameters.AddWithValue(parameters[i], ingredients[i]);
                            ++i;
                        }

                        string sql = "SELECT r.recipe_id, r.title, r.image, r.date, COUNT(r.recipe_id) AS search_rate\n" +
                                     "FROM dbo.Recipe r JOIN dbo.RecipeIngredient ri ON ri.recipe_id = r.recipe_id\n" +
                                     "JOIN dbo.Ingredient i ON i.ingre_id = ri.ingre_id\n" +
                                     "WHERE i.name IN ({0})\n" +
                                     "GROUP BY r.recipe_id, r.title, r.image, r.date\n" +
                                     "ORDER BY search_rate DESC\n";
                        cmd.CommandText = string.Format(sql, string.Join(", ", parameters));

                        using (reader = cmd.ExecuteReader())
                        {
                            list = new List<Recipe>();
                            while (reader.Read())
                            {
                                int id = (int)reader["recipe_id"];
                                string title = (string) reader["title"];
                                DateTime date = DateTime.Parse(reader["date"].ToString());
                                string image = reader["image"] as string;
                                Recipe recipe = new Recipe(id, title, date, image);
                                list.Add(recipe);
                            }
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return list;
        }
    }
}
