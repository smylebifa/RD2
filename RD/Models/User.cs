using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? FullName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAdmin { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public User(Guid id, string? login, string? password, string? fullName)
        {
            Id = id;
            Login = login;
            Password = password;
            FullName = fullName;

            IsActive = true;
            IsAdmin = false;
        }

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}
