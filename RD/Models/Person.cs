using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }

        public Person(int id, string? login)
        {
            Id = id;
            Login = login;            
        }

        public Person(int id, string? login, string passwordHash, string salt)
        {
            Id = id;
            Login = login;
            PasswordHash = passwordHash;
            Salt = salt;
        }

        public Person()
        {
        }

        //public Person(int id, string? login, string? passwordHash, string? salt)
        //{
        //    Id = id;
        //    Login = login;
        //    PasswordHash = passwordHash;
        //    Salt = salt;
        //}
    }
}
