using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? FullName { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        
        public string Email { get; set; }

        //public DateTime? CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }

        public User(int id, string? login, string? password, string? fullName, string? email)
        {
            Id = id;
            Login = login;
            Password = password;
            FullName = fullName;
            Email = email;

            IsActive = true;
            IsAdmin = false;
        }

        public User(int id, string? login, string? password, string? fullName, string? email, bool isAdmin)
        {
            Id = id;
            Login = login;
            Password = password;
            FullName = fullName;
            Email = email;

            IsActive = true;
            IsAdmin = isAdmin;
        }

        public User()
        {
            Id = 1;
        }
    }
}
