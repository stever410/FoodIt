using FoodIt.db;
using FoodIt.dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodIt.daos
{
    public class UserDAO
    {
        private SqlConnection cnn;
        private SqlCommand cmd;

        public UserDAO(){}

        public User CheckLogin(string email, string password)
        {
            User dto = null;
            string sql = "SELECT username, role, image, status FROM [User] WHERE email = @email AND password = @password";         
            try
            {
                using(cnn = MyConnection.getMyConnection())
                {
                    cnn.Open();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    string username = reader["username"] as string;
                                    string role = reader["role"] as string;
                                    string image = reader["image"] as string;
                                    string status = reader["status"] as string;
                                    dto = new User(email, username, null, role, image, status);
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return dto;
        }

        public bool AddUser(User user)
        {
            string sql = "Insert [User] values(@email, @username, @password, @role, @image, @status)";
            try
            {
                using (cnn = MyConnection.getMyConnection())
                {
                    cnn.Open();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@role", user.Role);
                        cmd.Parameters.AddWithValue("@image", user.Image);
                        cmd.Parameters.AddWithValue("@status", user.Status);
                    }
                }
                int count = cmd.ExecuteNonQuery();
                return (count > 0);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }

        public User FindUserByEmail(string email)
        {
            User dto = null;
            string sql = "SELECT username, password, role, image, status FROM [User] WHERE email = @email";
            try
            {
                using (cnn = MyConnection.getMyConnection())
                {
                    cnn.Open();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    string username = reader["username"] as string;
                                    string password = reader["password"] as string;
                                    string role = reader["role"] as string;
                                    string image = reader["image"] as string;
                                    string status = reader["status"] as string;
                                    dto = new User(email, username, password, role, image, status);
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return dto;
        }
    }
}
