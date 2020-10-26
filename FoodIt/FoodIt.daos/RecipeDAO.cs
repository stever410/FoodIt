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
        private static SqlConnection con;
        private static SqlCommand cmd;
        private static SqlDataAdapter da;

        public static List<Recipe> GetAllRecipes()
        {
            List<Recipe> list = null;

            String sql = "SELECT recipe_id, title, date, image " +
                "FROM Recipe WHERE status NOT LIKE 'deleted'";

            con = MyConnection.GetMyConnection();
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int) reader["recipe_id"];
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
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }

            return list;
        }

    }
}
