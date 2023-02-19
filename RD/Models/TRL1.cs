using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class TRL1
    {
        public int Id { get; set; }
        
        public bool[]? Trl1 { get; set; }
        public bool[]? Trl2 { get; set; }
        public bool[]? Trl3 { get; set; }
        public bool[]? Trl4 { get; set; }
        public bool[]? Trl5 { get; set; }
        public bool[]? Trl6 { get; set; }
        public bool[]? Trl7 { get; set; }
        public bool[]? Trl8 { get; set; }


        public bool? Trl1_1 { get; set; }
        public bool? Trl1_2 { get; set; }
        public bool? Trl1_3 { get; set; }
        public bool? Trl1_4 { get; set; }

        public bool? Trl2_1 { get; set; }
        public bool? Trl2_2 { get; set; }
        public bool? Trl2_3 { get; set; }
        public bool? Trl2_4 { get; set; }
        public bool? Trl2_5 { get; set; }
        public bool? Trl2_6 { get; set; }
        public bool? Trl2_7 { get; set; }
        public bool? Trl2_8 { get; set; }
        public bool? Trl2_9 { get; set; }


        public bool? Trl3_1 { get; set; }
        public bool? Trl3_2 { get; set; }
        public bool? Trl3_3 { get; set; }
        public bool? Trl3_4 { get; set; }
        public bool? Trl3_5 { get; set; }
        public bool? Trl3_6 { get; set; }
        public bool? Trl3_7 { get; set; }
        public bool? Trl3_8 { get; set; }
        public bool? Trl3_9 { get; set; }
        public bool? Trl3_10 { get; set; }
        public bool? Trl3_11 { get; set; }
        public bool? Trl3_12 { get; set; }



        public bool? Trl4_1 { get; set; }
        public bool? Trl4_2 { get; set; }
        public bool? Trl4_3 { get; set; }
        public bool? Trl4_4 { get; set; }
        public bool? Trl4_5 { get; set; }
        public bool? Trl4_6 { get; set; }
        public bool? Trl4_7 { get; set; }
        public bool? Trl4_8 { get; set; }
        public bool? Trl4_9 { get; set; }
        public bool? Trl4_10 { get; set; }
        public bool? Trl4_11 { get; set; }
        public bool? Trl4_12 { get; set; }
        public bool? Trl4_13 { get; set; }
        public bool? Trl4_14 { get; set; }
        public bool? Trl4_15 { get; set; }
        public bool? Trl4_16 { get; set; }
        public bool? Trl4_17 { get; set; }



        public bool? Trl5_1 { get; set; }
        public bool? Trl5_2 { get; set; }
        public bool? Trl5_3 { get; set; }
        public bool? Trl5_4 { get; set; }
        public bool? Trl5_5 { get; set; }
        public bool? Trl5_6 { get; set; }
        public bool? Trl5_7 { get; set; }
        public bool? Trl5_8 { get; set; }
        public bool? Trl5_9 { get; set; }
        public bool? Trl5_10 { get; set; }
        public bool? Trl5_11 { get; set; }
        public bool? Trl5_12 { get; set; }



        public bool? Trl6_1 { get; set; }
        public bool? Trl6_2 { get; set; }
        public bool? Trl6_3 { get; set; }
        public bool? Trl6_4 { get; set; }
        public bool? Trl6_5 { get; set; }
        public bool? Trl6_6 { get; set; }
        public bool? Trl6_7 { get; set; }
        public bool? Trl6_8 { get; set; }
        public bool? Trl6_9 { get; set; }
        public bool? Trl6_10 { get; set; }
        public bool? Trl6_11 { get; set; }
        public bool? Trl6_12 { get; set; }
        public bool? Trl6_13 { get; set; }
        public bool? Trl6_14 { get; set; }
        public bool? Trl6_15 { get; set; }
        public bool? Trl6_16 { get; set; }




        public bool? Trl7_1 { get; set; }
        public bool? Trl7_2 { get; set; }
        public bool? Trl7_3 { get; set; }
        public bool? Trl7_4 { get; set; }
        public bool? Trl7_5 { get; set; }
        public bool? Trl7_6 { get; set; }
        public bool? Trl7_7 { get; set; }


        public bool? Trl8_1 { get; set; }
        public bool? Trl8_2 { get; set; }
        public bool? Trl8_3 { get; set; }
        public bool? Trl8_4 { get; set; }
        public bool? Trl8_5 { get; set; }




        public string? ThemeName { get; set; }

        public int? TotalCount { get; set; }


        public TRL1(string themeName, bool[]? trl1, bool[]? trl2, bool[]? trl3, bool[]? trl4, bool[]? trl5, bool[]? trl6, bool[]? trl7, bool[]? trl8, int? totalReady)
        {
            //Id = Guid.NewGuid();

            ThemeName = themeName;

            Trl1 = trl1;
            Trl2 = trl2;
            Trl3 = trl3;
            Trl4 = trl4;
            Trl5 = trl5;
            Trl6 = trl6;
            Trl7 = trl7;
            Trl8 = trl8;

        }

        public TRL1()
        {
            //Id = Guid.NewGuid();
           
            Trl1 = new bool[4];
            Trl2 = new bool[9];
            Trl3 = new bool[12];

            Trl4 = new bool[17];
            Trl5 = new bool[12];
            Trl6 = new bool[16];

            Trl7 = new bool[7];
            Trl8 = new bool[5];
            
        }

        public TRL1(string themeName)
        {
            //Id = Guid.NewGuid();

            Trl1 = new bool[4];
            Trl2 = new bool[9];
            Trl3 = new bool[12];

            Trl4 = new bool[17];
            Trl5 = new bool[12];
            Trl6 = new bool[16];

            Trl7 = new bool[7];
            Trl8 = new bool[5];

            ThemeName = themeName;

        }

        public TRL1(string themeName, int totalCount)
        {
            //Id = Guid.NewGuid();

            Trl1 = new bool[4];
            Trl2 = new bool[9];
            Trl3 = new bool[12];

            Trl4 = new bool[17];
            Trl5 = new bool[12];
            Trl6 = new bool[16];

            Trl7 = new bool[7];
            Trl8 = new bool[5];

            ThemeName = themeName;

            TotalCount = totalCount;

        }
    }
}
