using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodIt.dtos
{
    public class User
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
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
