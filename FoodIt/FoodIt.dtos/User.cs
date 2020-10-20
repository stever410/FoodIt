using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodIt.dtos
{
    public class User
    {
        public const string MEMBER = "member";
        public const string DEFAULT_STATUS = "active";
        private string email;
        private string username;
        private string password;
        private string role;
        private string image;
        private string status;
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string Image { get => image; set => image = value; }
        public string Status { get => status; set => status = value; }
        public User(string email, string username, string password, string role, string image, string status)
        {
            Email = email;
            Username = username;
            Password = password;
            Role = role;
            Image = image;
            Status = status;
        }
    }
}
