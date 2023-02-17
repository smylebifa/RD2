using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class TRL1
    {
        public int Id { get; set; }
        public bool? Trl1_1 { get; set; }
        public bool? Trl1_2 { get; set; }
        public bool? Trl1_3 { get; set; }
        public bool? Trl1_4 { get; set; }
        public bool? Trl1_5 { get; set; }
        public bool? Trl2_1 { get; set; }
        public bool? Trl2_2 { get; set; }
        public bool? Trl2_3 { get; set; }
        public bool? Trl2_4 { get; set; }
        public bool? Trl2_5 { get; set; }

        public string? ThemeName { get; set; }

        public int? TotalReady { get; set; }


        public TRL1(string themeName, bool? trl1_1, bool? trl1_2, bool? trl1_3, bool? trl1_4, bool? trl1_5,
            bool? trl2_1, bool? trl2_2, bool? trl2_3, bool? trl2_4, bool? trl2_5, int? totalReady)
        {
            //Id = Guid.NewGuid();

            ThemeName = themeName;

            Trl1_1 = trl1_1;
            Trl1_2 = trl1_2;
            Trl1_3 = trl1_3;
            Trl1_4 = trl1_4;
            Trl1_5 = trl1_5;
            Trl2_1 = trl2_1;
            Trl2_2 = trl2_2;
            Trl2_3 = trl2_3;
            Trl2_4 = trl2_4;
            Trl2_5 = trl2_5;

            TotalReady = totalReady;
        }

        public TRL1()
        {
            //Id = Guid.NewGuid();
            ThemeName = "Theme 1";
        }
}
}
