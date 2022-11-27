using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int StageId { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }

        public Product(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        public Product(int id, string? name, string? location)
        {
            Id = id;
            Name = name;
            Location = location;
        }

        public Product()
        {
        }

    }
}
