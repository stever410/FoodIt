using FoodIt.Foodit.dtos;
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
        private const string CONNECTION_STRING =
            "server=SE140190;database=FoodIt;uid=sa;pwd=123456";

        public static List<Recipe> GetAllRecipes()
        {
            List<Recipe> list = null;

            String sql = "SELECT recipe_id, title, date, image, category " +
                "FROM Recipe WHERE status NOT LIKE 'deleted'";

            con = new SqlConnection(CONNECTION_STRING);
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string recipeId = reader.GetString(0);
                    string title = reader.GetString(1);
                    DateTime date = reader.GetDateTime(2);
                    string image = reader.GetString(3);
                    string category = reader.GetString(4);

                    Recipe recipe = new Recipe(recipeId, title, date, image, category);

                    if (list == null)
                    {
                        list = new List<Recipe>();
                    }

                    list.Add(recipe);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }

            return list;
        }
    }
}
