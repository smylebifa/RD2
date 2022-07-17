using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int? Cash { get; set; }

        public User(Guid id, string? name, string? email, int? cash)
        {
            Id = id;
            Name = name;
            Email = email;
            Cash = cash;
        }

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}
