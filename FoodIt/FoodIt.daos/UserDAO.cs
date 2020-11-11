using FoodIt.db;
using FoodIt.dtos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FoodIt.daos
{
    public class UserDAO
    {
        private SqlConnection cnn;
        private SqlCommand cmd;

        public UserDAO() { }

        public User CheckLogin(string email, string password)
        {
            User dto = null;
            string sql = "SELECT * FROM [User] WHERE email = @email AND password = @password";
            try
            {
                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult))
                        {
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

        public bool UpdateUser(User user)
        {
            bool check = false;
            string sql = "Update [User] set username = @username, password = @password where email = @email";
            try
            {
                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        check = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return check;
        }

        public bool AddUser(User user)
        {
            bool check = false;
            string SQL = "Insert [User] values(@email, @username, @password, @role, @image, @status)";
            try
            {
                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(SQL, cnn))
                    {
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@role", user.Role);
                        cmd.Parameters.AddWithValue("@image", user.Image);
                        cmd.Parameters.AddWithValue("@status", user.Status);
                        check = cmd.ExecuteNonQuery() > 0;
                    }
                }
            } catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return check;
        }

        public User FindUserByEmail(string email)
        {
            User dto = null;
            string sql = "SELECT username, password, role, image, status FROM [User] WHERE email = @email";
            try
            {
                using (cnn = MyConnection.GetMyConnection())
                {
                    cnn.Open();
                    using (cmd = new SqlCommand(sql, cnn))
                    {
                        cmd = new SqlCommand(sql, cnn);
                        cmd.Parameters.AddWithValue("@email", email);
                        using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult))
                        {
                            if (reader.HasRows)
                            {
                                if(reader.Read())
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
