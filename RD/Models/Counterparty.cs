using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class Counterparty
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Counterparty()
        {
            Id = 1;
        }

        public Counterparty(string name)
        {
            Name = name;
        }
    }
}
