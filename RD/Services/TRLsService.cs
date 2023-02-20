using RD.Data;
using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Services
{
    //public class TRLsService : ITRLsService
    public class TRLsService 
    {
        //private readonly TestDbContext _dbContext;

        //public TRLsService(TestDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        private static readonly List<TRL1> TRLs1 = new List<TRL1>();


        //public void SaveTRL1(string themeName, bool trl1_1, bool trl1_2, bool trl1_3, bool trl1_4,
        //    bool trl2_1, bool trl2_2, bool trl2_3, bool trl2_4, bool trl2_5, bool trl2_6, bool trl2_7, bool trl2_8, bool trl2_9,
        //    bool trl3_1, bool trl3_2, bool trl3_3, bool trl3_4, bool trl3_5, bool trl3_6, bool trl3_7, bool trl3_8, bool trl3_9, bool trl3_10, bool trl3_11, bool trl3_12,
        //    bool trl4_1, bool trl4_2, bool trl4_3, bool trl4_4, bool trl4_5, bool trl4_6, bool trl4_7, bool trl4_8, bool trl4_9, bool trl4_10, bool trl4_11, bool trl4_12,
        //    bool trl4_13, bool trl4_14, bool trl4_15, bool trl4_16, bool trl4_17)
        //{

        //public void SaveTRL1(string themeName, bool[] trl3, bool[] trl4)
        //{
            public void SaveTRL1(string themeName, TRL1 trl1)
        {
            //var Trl = _dbContext.TRLs.FirstOrDefault(x => x.StageName == themeName);

            //Trl.TotalCount = count;

            //_dbContext.SaveChanges();

            var Trl1 = TRLs1.FirstOrDefault(x => x.ThemeName == themeName);

            if (Trl1 != null)
            {
                int count = 0;

                if (trl1.Trl1_1 == true)
                        count++;

                if (trl1.Trl1_2 == true)
                    count++;

                if (trl1.Trl1_3 == true)
                    count++;

                if (trl1.Trl1_4 == true)
                    count++;


                if (trl1.Trl2_1 == true)
                    count++;

                if (trl1.Trl2_2 == true)
                    count++;

                if (trl1.Trl2_3 == true)
                    count++;

                if (trl1.Trl2_4 == true)
                    count++;

                if (trl1.Trl2_5 == true)
                    count++;

                if (trl1.Trl2_6 == true)
                    count++;

                if (trl1.Trl2_7 == true)
                    count++;

                if (trl1.Trl2_8 == true)
                    count++;

                if (trl1.Trl2_9 == true)
                    count++;


                if (trl1.Trl3_1 == true)
                    count++;

                if (trl1.Trl3_2 == true)
                    count++;

                if (trl1.Trl3_3 == true)
                    count++;

                if (trl1.Trl3_4 == true)
                    count++;

                if (trl1.Trl3_5 == true)
                    count++;

                if (trl1.Trl3_6 == true)
                    count++;

                if (trl1.Trl3_7 == true)
                    count++;

                if (trl1.Trl3_8 == true)
                    count++;

                if (trl1.Trl3_9 == true)
                    count++;

                if (trl1.Trl3_10 == true)
                    count++;

                if (trl1.Trl3_11 == true)
                    count++;

                if (trl1.Trl3_12 == true)
                    count++;


                if (trl1.Trl4_1 == true)
                    count++;

                if (trl1.Trl4_2 == true)
                    count++;

                if (trl1.Trl4_3 == true)
                    count++;

                if (trl1.Trl4_4 == true)
                    count++;

                if (trl1.Trl4_5 == true)
                    count++;

                if (trl1.Trl4_6 == true)
                    count++;

                if (trl1.Trl4_7 == true)
                    count++;

                if (trl1.Trl4_8 == true)
                    count++;

                if (trl1.Trl4_9 == true)
                    count++;

                if (trl1.Trl4_10 == true)
                    count++;

                if (trl1.Trl4_11 == true)
                    count++;

                if (trl1.Trl4_12 == true)
                    count++;

                if (trl1.Trl4_13 == true)
                    count++;

                if (trl1.Trl4_14 == true)
                    count++;

                if (trl1.Trl4_15 == true)
                    count++;

                if (trl1.Trl4_16 == true)
                    count++;

                if (trl1.Trl4_17 == true)
                    count++;


                if (trl1.Trl5_1 == true)
                    count++;

                if (trl1.Trl5_2 == true)
                    count++;

                if (trl1.Trl5_3 == true)
                    count++;

                if (trl1.Trl5_4 == true)
                    count++;

                if (trl1.Trl5_5 == true)
                    count++;

                if (trl1.Trl5_6 == true)
                    count++;

                if (trl1.Trl5_7 == true)
                    count++;

                if (trl1.Trl5_8 == true)
                    count++;

                if (trl1.Trl5_9 == true)
                    count++;

                if (trl1.Trl5_10 == true)
                    count++;

                if (trl1.Trl5_11 == true)
                    count++;

                if (trl1.Trl5_12 == true)
                    count++;



                if (trl1.Trl6_1 == true)
                    count++;

                if (trl1.Trl6_2 == true)
                    count++;

                if (trl1.Trl6_3 == true)
                    count++;

                if (trl1.Trl6_4 == true)
                    count++;

                if (trl1.Trl6_5 == true)
                    count++;

                if (trl1.Trl6_6 == true)
                    count++;

                if (trl1.Trl6_7 == true)
                    count++;

                if (trl1.Trl6_8 == true)
                    count++;

                if (trl1.Trl6_9 == true)
                    count++;

                if (trl1.Trl6_10 == true)
                    count++;

                if (trl1.Trl6_11 == true)
                    count++;

                if (trl1.Trl6_12 == true)
                    count++;

                if (trl1.Trl6_13 == true)
                    count++;

                if (trl1.Trl6_14 == true)
                    count++;

                if (trl1.Trl6_15 == true)
                    count++;

                if (trl1.Trl6_16 == true)
                    count++;


                if (trl1.Trl7_1 == true)
                    count++;

                if (trl1.Trl7_2 == true)
                    count++;

                if (trl1.Trl7_3 == true)
                    count++;

                if (trl1.Trl7_4 == true)
                    count++;

                if (trl1.Trl7_5 == true)
                    count++;

                if (trl1.Trl7_6 == true)
                    count++;

                if (trl1.Trl7_7 == true)
                    count++;



                if (trl1.Trl8_1 == true)
                    count++;

                if (trl1.Trl8_2 == true)
                    count++;

                if (trl1.Trl8_3 == true)
                    count++;

                if (trl1.Trl8_4 == true)
                    count++;

                if (trl1.Trl8_5 == true)
                    count++;


                trl1.TotalCount = count;

               
                TRLs1.Remove(Trl1);

                TRLs1.Add(trl1);

            }
            
        }

        

        public TRL1 GetTrls1(string themeName)
        {
            //var existing = _dbContext.TRLs.FirstOrDefault(x => x.StageName == themeName);

            //if (existing == null)
            //{
            //    TRL trl = new TRL(themeName, false, false, false, false, false, false, false, false, false, false, 0);
            //    _dbContext.Add(trl);
            //    _dbContext.SaveChanges();
            //    return trl;
            //}
            //else
            //{
            //    return existing;
            //}

            if (TRLs1.Count == 0)
            {
                TRL1 trl1 = new TRL1(themeName, 0);
                TRLs1.Add(trl1);
                return trl1;
            }

            else
            {
                var existing = TRLs1.FirstOrDefault(x => x.ThemeName == themeName);

                if (existing == null)
                {
                    TRL1 trl1 = new TRL1(themeName, 0);
                    TRLs1.Add(trl1);
                    return trl1;
                }

                else
                {
                    return existing;
                }
            }

            
        }      
       

    }
}
