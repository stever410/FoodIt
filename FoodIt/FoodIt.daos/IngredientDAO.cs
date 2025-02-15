﻿using FoodIt.db;
using FoodIt.dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace FoodIt.daos
{
    public class IngredientDAO
    {
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader reader;

        public List<Ingredient> GetAllIngredients()
        {
            List<Ingredient> ingredients = null;
            Ingredient ingredient;
            int id;
            string name, description, status;
            string image = null, unit = null;
            string sql = "Select ingre_id, name, description, unit, image, status From Ingredient ORDER BY name ASC";
            try
            {
                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        using (reader = cmd.ExecuteReader())
                        {
                            ingredients = new List<Ingredient>();
                            while (reader.Read())
                            {
                                id = (int)reader["ingre_id"];
                                name = (string)reader["name"];
                                description = (string)reader["description"];
                                if (!reader.IsDBNull(reader.GetOrdinal("unit")))
                                {
                                    unit = (string)reader["unit"];
                                }
                                if (!reader.IsDBNull(reader.GetOrdinal("image")))
                                {
                                    image = (string)reader["image"];
                                }
                                status = (string)reader["status"];
                                ingredient = new Ingredient(id, name, description, unit, image, status);
                                ingredients.Add(ingredient);
                            }
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return ingredients;
        }

        public int GetIngredientIDByName(string name)
        {
            int id = -1;
            string sql = "Select ingre_id From Ingredient Where name = @name";
            try
            {
                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    using(cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        using(reader = cmd.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                id = int.Parse(reader["ingre_id"].ToString());
                            }
                        }
                    }
                }
            }
            catch(SqlException se)
            {
                throw new Exception(se.Message);
            }
            return id;
        }

        public string GetIngredientNameByID(int id)
        {
            string name = null;
            string sql = "Select name From Ingredient Where ingre_id = @id";
            try
            {
                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                name = (string)reader["name"];
                            }
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return name;
        }

        public List<Ingredient> GetAllIngredientsByRecipe(Recipe recipe)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            try
            {

                string sql = @"SELECT Ingredient.ingre_id, [name], Ingredient.description, amount_ingre 
                                FROM dbo.Recipe, dbo.RecipeIngredient, dbo.Ingredient
                                WHERE Recipe.recipe_id = RecipeIngredient.recipe_id 
                                AND Ingredient.ingre_id = RecipeIngredient.ingre_id 
                                AND Recipe.recipe_id = @id";

                using(cnn = MyConnection.GetMyConnection())
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
                                string name = reader["name"] as string;
                                string description = reader["description"] as string;
                                string amount = reader["amount_ingre"] as string;

                                Ingredient ingredient = new Ingredient(ingreId, name, description, amount);

                                ingredients.Add(ingredient);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return ingredients;
        }
        public string GetIngredientUnitByName(string name)
        {
            string unit = null;
            string sql = "Select unit From Ingredient Where name = @name";
            try
            {
                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        using (reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                unit = reader["unit"].ToString();
                            }
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return unit;
        }
    }
}
