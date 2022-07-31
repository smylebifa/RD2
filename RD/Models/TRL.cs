using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class TRL
    {
        public Guid Id { get; set; }
        public bool? Trl1 { get; set; }
        public bool? Trl2 { get; set; }
        public string? StageName { get; set; }

        public TRL(bool trl1, bool trl2)
        {
            Id = Guid.NewGuid();
            StageName = "a";


            Trl1 = trl1;
            Trl2 = trl2;
        }

        public TRL()
        {
            Id = Guid.NewGuid();
            StageName = "a";
        }
}
}
