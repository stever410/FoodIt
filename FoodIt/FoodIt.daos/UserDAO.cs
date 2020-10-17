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

        public User checkLogin(string email, string password)
        {
            User dto = null;
            string sql = "SELECT * FROM [User] WHERE email = @email AND password = @password";
            cnn = MyConnection.getMyConnection();
            cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string username = reader["username"] as string;
                        string role = reader["role"] as string;
                        string image = reader["image"] as string;
                        string status = reader["status"] as string;
                        dto = new User(email, username, null, role, image, status);
                    }
                }
                cnn.Close();
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return dto;
        }

        public bool addUser(User user)
        {
            string SQL = "Insert [User] values(@email, @username, @password, @role, @image, @status)";
            cnn = MyConnection.getMyConnection();
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Parameters.AddWithValue("@image", user.Image);
            cmd.Parameters.AddWithValue("@status", user.Status);
            cnn.Open();
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }

        public User findUserByEmail(string email)
        {
            User dto = null;
            string sql = "SELECT * FROM [User] WHERE email = @email";
            cnn = MyConnection.getMyConnection();
            cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string username = reader["username"] as string;
                        string password = reader["password"] as string;
                        string role = reader["role"] as string;
                        string image = reader["image"] as string;
                        string status = reader["status"] as string;
                        dto = new User(email, username, password, role, image, status);
                    }
                }
                cnn.Close();
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return dto;
        }
    }
}
