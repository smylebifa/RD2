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
        public string Email { get; set; }
        public string? FullName { get; set; }

        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }


        //public DateTime? CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }

        public User() { }


        public User(int id, string? login, string? password)
        {
            Id = id;
            Login = login;
            Password = password;
           
        }

        public User(int id, string? login, string? password, string? email)
        {
            Id = id;
            Login = login;
            Password = password;
            Email = email;

        }

        public User(int id, string? login, string? password, string? email, string? fullName)
        {
            Id = id;
            Login = login;
            Password = password;
            Email = email;
            FullName = fullName;
        }

        //public User(int id, string? login, string? password, string? email, string? fullName, bool isActive)
        //{
        //    Id = id;
        //    Login = login;
        //    Password = password;
        //    Email = email;
        //    FullName = fullName;
        //    IsActive = isActive;
        //}

        public User(int id, string? login, string? password, string? email, string? fullName, bool isActive = false, bool isAdmin = false)
        {
            Id = id;
            Login = login;
            Password = password;
            Email = email;
            FullName = fullName;
            IsActive = isActive;
            IsAdmin = isAdmin;
        }

        //public User(int id, string? login, string? password, string? fullName, string? email, bool isAdmin)
        //{
        //    Id = id;
        //    Login = login;
        //    Password = password;
        //    FullName = fullName;
        //    Email = email;

        //    IsActive = true;
        //    IsAdmin = isAdmin;
        //}
    }
}
