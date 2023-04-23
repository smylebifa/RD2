﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class TRL2
    {
        public int Id { get; set; }

        public bool Trl1_1 { get; set; }
        public bool Trl1_2 { get; set; }
        public bool Trl1_3 { get; set; }
        public bool Trl1_4 { get; set; }

        public bool Trl2_1 { get; set; }
        public bool Trl2_2 { get; set; }
        public bool Trl2_3 { get; set; }
        


        public bool Trl3_1 { get; set; }
        public bool Trl3_2 { get; set; }
        public bool Trl3_3 { get; set; }
        public bool Trl3_4 { get; set; }
        public bool Trl3_5 { get; set; }
        public bool Trl3_6 { get; set; }
        public bool Trl3_7 { get; set; }
        public bool Trl3_8 { get; set; }
        


        public bool Trl4_1 { get; set; }
        public bool Trl4_2 { get; set; }
        public bool Trl4_3 { get; set; }
        public bool Trl4_4 { get; set; }
        public bool Trl4_5 { get; set; }
        public bool Trl4_6 { get; set; }
        public bool Trl4_7 { get; set; }
        public bool Trl4_8 { get; set; }
        public bool Trl4_9 { get; set; }
        public bool Trl4_10 { get; set; }
        public bool Trl4_11 { get; set; }
        

        public bool Trl5_1 { get; set; }
        public bool Trl5_2 { get; set; }
        public bool Trl5_3 { get; set; }
        public bool Trl5_4 { get; set; }
        public bool Trl5_5 { get; set; }
        public bool Trl5_6 { get; set; }
        public bool Trl5_7 { get; set; }
        public bool Trl5_8 { get; set; }
        public bool Trl5_9 { get; set; }
        public bool Trl5_10 { get; set; }
        

        public bool Trl6_1 { get; set; }
        public bool Trl6_2 { get; set; }
        public bool Trl6_3 { get; set; }
        public bool Trl6_4 { get; set; }
        public bool Trl6_5 { get; set; }
        public bool Trl6_6 { get; set; }
        public bool Trl6_7 { get; set; }
        public bool Trl6_8 { get; set; }
        public bool Trl6_9 { get; set; }
        public bool Trl6_10 { get; set; }
        

        public bool Trl7_1 { get; set; }
        public bool Trl7_2 { get; set; }
        public bool Trl7_3 { get; set; }
        public bool Trl7_4 { get; set; }
       

        public bool Trl8_1 { get; set; }
        public bool Trl8_2 { get; set; }
        public bool Trl8_3 { get; set; }
        public bool Trl8_4 { get; set; }

        public bool Trl1 { get; set; }
        public bool Trl2x { get; set; }
        public bool Trl3 { get; set; }
        public bool Trl4 { get; set; }
        public bool Trl5 { get; set; }
        public bool Trl6 { get; set; }
        public bool Trl7 { get; set; }
        public bool Trl8 { get; set; }

        public string ThemeName { get; set; }

        public int? TotalCount { get; set; }
        public int StageId { get; set; }

        public TRL2() { }

        public TRL2(string themeName, int stageId, int totalCount = 0)
        {
            Trl1_1 = false;
            Trl1_2 = false;
            Trl1_3 = false;
            Trl1_4 = false;

            Trl2_1 = false;
            Trl2_2 = false;
            Trl2_3 = false;
           


            Trl3_1 = false;
            Trl3_2 = false;
            Trl3_3 = false;
            Trl3_4 = false;
            Trl3_5 = false;
            Trl3_6 = false;
            Trl3_7 = false;
            Trl3_8 = false;
          


            Trl4_1 = false;
            Trl4_2 = false;
            Trl4_3 = false;
            Trl4_4 = false;
            Trl4_5 = false;
            Trl4_6 = false;
            Trl4_7 = false;
            Trl4_8 = false;
            Trl4_9 = false;
            Trl4_10 = false;
            Trl4_11 = false;
            



            Trl5_1 = false;
            Trl5_2 = false;
            Trl5_3 = false;
            Trl5_4 = false;
            Trl5_5 = false;
            Trl5_6 = false;
            Trl5_7 = false;
            Trl5_8 = false;
            Trl5_9 = false;
            Trl5_10 = false;
            



            Trl6_1 = false;
            Trl6_2 = false;
            Trl6_3 = false;
            Trl6_4 = false;
            Trl6_5 = false;
            Trl6_6 = false;
            Trl6_7 = false;
            Trl6_8 = false;
            Trl6_9 = false;
            Trl6_10 = false;
            


            Trl7_1 = false;
            Trl7_2 = false;
            Trl7_3 = false;
            Trl7_4 = false;
            

            Trl8_1 = false;
            Trl8_2 = false;
            Trl8_3 = false;
            Trl8_4 = false;

            Trl1 = false;
            Trl2x = false;
            Trl3 = false;
            Trl4 = false;
            Trl5 = false;
            Trl6 = false;
            Trl7 = false;
            Trl8 = false;

            StageId = stageId;

            ThemeName = themeName;

            TotalCount = totalCount;

        }
    }
}
