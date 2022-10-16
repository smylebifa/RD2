using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Customer()
        {
            Id = 1;
        }

        public Customer(int id, string name)
        {
            Id = id; 
            Name = name;
        }
        public Customer(string name)
        {
            Name = name;
        }
    }
}
