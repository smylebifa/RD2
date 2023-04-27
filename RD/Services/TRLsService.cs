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

        private static readonly List<TRL1> TRLs1 = new List<TRL1> { new TRL1("Teма 1", 1, 0) };
        private static readonly List<TRL2> TRLs2 = new List<TRL2> { new TRL2("Teма 1", 1, 0) };
        private static readonly List<TRL3> TRLs3 = new List<TRL3> { new TRL3("Teма 1", 1, 0) };


        //public void SaveTRL1(string themeName, bool trl1_1, bool trl1_2, bool trl1_3, bool trl1_4,
        //    bool trl2_1, bool trl2_2, bool trl2_3, bool trl2_4, bool trl2_5, bool trl2_6, bool trl2_7, bool trl2_8, bool trl2_9,
        //    bool trl3_1, bool trl3_2, bool trl3_3, bool trl3_4, bool trl3_5, bool trl3_6, bool trl3_7, bool trl3_8, bool trl3_9, bool trl3_10, bool trl3_11, bool trl3_12,
        //    bool trl4_1, bool trl4_2, bool trl4_3, bool trl4_4, bool trl4_5, bool trl4_6, bool trl4_7, bool trl4_8, bool trl4_9, bool trl4_10, bool trl4_11, bool trl4_12,
        //    bool trl4_13, bool trl4_14, bool trl4_15, bool trl4_16, bool trl4_17)
        //{

        //public void SaveTRL1(string themeName, bool[] trl3, bool[] trl4)
        //{
        public void SaveTRL1(string themeName, int stageId, TRL1 trl1)
        {
            //var Trl = _dbContext.TRLs.FirstOrDefault(x => x.StageName == themeName);

            //Trl.TotalCount = count;

            //_dbContext.SaveChanges();

            var Trl1 = TRLs1.FirstOrDefault(x => x.ThemeName == themeName && x.StageId == stageId);

            if (Trl1 != null)
            {

                if (trl1.Trl1_1 && trl1.Trl1_2 && trl1.Trl1_3 && trl1.Trl1_4)
                {
                    trl1.Trl1x = true;
                }

                if (trl1.Trl2_1 && trl1.Trl2_2 && trl1.Trl2_3 && trl1.Trl2_4 && trl1.Trl2_5 && trl1.Trl2_6 && trl1.Trl2_7 && trl1.Trl2_8 && trl1.Trl2_9)
                {
                    trl1.Trl2 = true;
                }

                if (trl1.Trl3_1 && trl1.Trl3_2 && trl1.Trl3_3 && trl1.Trl3_4 && trl1.Trl3_5 && trl1.Trl3_6 && trl1.Trl3_7 && trl1.Trl3_8 && trl1.Trl3_9
                    && trl1.Trl3_10 && trl1.Trl3_11 && trl1.Trl3_12)
                {
                    trl1.Trl3 = true;
                }

                if (trl1.Trl4_1 && trl1.Trl4_2 && trl1.Trl4_3 && trl1.Trl4_4 && trl1.Trl4_5 && trl1.Trl4_6 && trl1.Trl4_7 && trl1.Trl4_8 && trl1.Trl4_9
                    && trl1.Trl4_10 && trl1.Trl4_11 && trl1.Trl4_12 && trl1.Trl4_13 && trl1.Trl4_14 && trl1.Trl4_15 && trl1.Trl4_16 && trl1.Trl4_17)
                {
                    trl1.Trl4 = true;
                }

                if (trl1.Trl5_1 && trl1.Trl5_2 && trl1.Trl5_3 && trl1.Trl5_4 && trl1.Trl5_5 && trl1.Trl5_6 && trl1.Trl5_7 && trl1.Trl5_8 && trl1.Trl5_9
                    && trl1.Trl5_10 && trl1.Trl5_11 && trl1.Trl5_12)
                {
                    trl1.Trl5 = true;
                }

                if (trl1.Trl6_1 && trl1.Trl6_2 && trl1.Trl6_3 && trl1.Trl6_4 && trl1.Trl6_5 && trl1.Trl6_6 && trl1.Trl6_7 && trl1.Trl6_8 && trl1.Trl6_9
                         && trl1.Trl6_10 && trl1.Trl6_11 && trl1.Trl6_12 && trl1.Trl6_13 && trl1.Trl6_14 && trl1.Trl6_15 && trl1.Trl6_16)
                {
                    trl1.Trl6 = true;
                }

                if (trl1.Trl7_1 && trl1.Trl7_2 && trl1.Trl7_3 && trl1.Trl7_4 && trl1.Trl7_5 && trl1.Trl7_6 && trl1.Trl7_7)
                {
                    trl1.Trl7 = true;
                }

                if (trl1.Trl8_1 && trl1.Trl8_2 && trl1.Trl8_3 && trl1.Trl8_4 && trl1.Trl8_5)
                {
                    trl1.Trl8 = true;
                }


                int count = 0;

                if (trl1.Trl0_1 == true)
                    count++;

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


        public void SaveTRL2(string themeName, int stageId, TRL2 trl2)
        {
            //var Trl = _dbContext.TRLs.FirstOrDefault(x => x.StageName == themeName);

            //Trl.TotalCount = count;

            //_dbContext.SaveChanges();

            var Trl2 = TRLs2.FirstOrDefault(x => x.ThemeName == themeName && x.StageId == stageId);

            if (Trl2 != null)
            {
                if (trl2.Trl1_1 && trl2.Trl1_2 && trl2.Trl1_3 && trl2.Trl1_4)
                {
                    trl2.Trl1 = true;
                }

                if (trl2.Trl2_1 && trl2.Trl2_2 && trl2.Trl2_3)
                {
                    trl2.Trl2x = true;
                }

                if (trl2.Trl3_1 && trl2.Trl3_2 && trl2.Trl3_3 && trl2.Trl3_4 && trl2.Trl3_5 && trl2.Trl3_6 && trl2.Trl3_7 && trl2.Trl3_8)
                {
                    trl2.Trl3 = true;
                }

                if (trl2.Trl4_1 && trl2.Trl4_2 && trl2.Trl4_3 && trl2.Trl4_4 && trl2.Trl4_5 && trl2.Trl4_6 && trl2.Trl4_7 && trl2.Trl4_8
                        && trl2.Trl4_9 && trl2.Trl4_10 && trl2.Trl4_11)
                {
                    trl2.Trl4 = true;
                }


                if (trl2.Trl5_1 && trl2.Trl5_2 && trl2.Trl5_3 && trl2.Trl5_4 && trl2.Trl5_5 && trl2.Trl5_6 && trl2.Trl5_7 && trl2.Trl5_8
                        && trl2.Trl5_9 && trl2.Trl5_10)
                {
                    trl2.Trl5 = true;
                }


                if (trl2.Trl6_1 && trl2.Trl6_2 && trl2.Trl6_3 && trl2.Trl6_4 && trl2.Trl6_5 && trl2.Trl6_6 && trl2.Trl6_7 && trl2.Trl6_8
                        && trl2.Trl6_9 && trl2.Trl6_10)
                {
                    trl2.Trl6 = true;
                }


                if (trl2.Trl7_1 && trl2.Trl7_2 && trl2.Trl7_3 && trl2.Trl7_4)
                {
                    trl2.Trl7 = true;
                }


                if (trl2.Trl8_1 && trl2.Trl8_2 && trl2.Trl8_3 && trl2.Trl8_4)
                {
                    trl2.Trl8 = true;
                }


                int count = 0;

                if (trl2.Trl1_1 == true)
                    count++;

                if (trl2.Trl1_2 == true)
                    count++;

                if (trl2.Trl1_3 == true)
                    count++;

                if (trl2.Trl1_4 == true)
                    count++;


                if (trl2.Trl2_1 == true)
                    count++;

                if (trl2.Trl2_2 == true)
                    count++;

                if (trl2.Trl2_3 == true)
                    count++;



                if (trl2.Trl3_1 == true)
                    count++;

                if (trl2.Trl3_2 == true)
                    count++;

                if (trl2.Trl3_3 == true)
                    count++;

                if (trl2.Trl3_4 == true)
                    count++;

                if (trl2.Trl3_5 == true)
                    count++;

                if (trl2.Trl3_6 == true)
                    count++;

                if (trl2.Trl3_7 == true)
                    count++;

                if (trl2.Trl3_8 == true)
                    count++;




                if (trl2.Trl4_1 == true)
                    count++;

                if (trl2.Trl4_2 == true)
                    count++;

                if (trl2.Trl4_3 == true)
                    count++;

                if (trl2.Trl4_4 == true)
                    count++;

                if (trl2.Trl4_5 == true)
                    count++;

                if (trl2.Trl4_6 == true)
                    count++;

                if (trl2.Trl4_7 == true)
                    count++;

                if (trl2.Trl4_8 == true)
                    count++;

                if (trl2.Trl4_9 == true)
                    count++;

                if (trl2.Trl4_10 == true)
                    count++;

                if (trl2.Trl4_11 == true)
                    count++;



                if (trl2.Trl5_1 == true)
                    count++;

                if (trl2.Trl5_2 == true)
                    count++;

                if (trl2.Trl5_3 == true)
                    count++;

                if (trl2.Trl5_4 == true)
                    count++;

                if (trl2.Trl5_5 == true)
                    count++;

                if (trl2.Trl5_6 == true)
                    count++;

                if (trl2.Trl5_7 == true)
                    count++;

                if (trl2.Trl5_8 == true)
                    count++;

                if (trl2.Trl5_9 == true)
                    count++;

                if (trl2.Trl5_10 == true)
                    count++;



                if (trl2.Trl6_1 == true)
                    count++;

                if (trl2.Trl6_2 == true)
                    count++;

                if (trl2.Trl6_3 == true)
                    count++;

                if (trl2.Trl6_4 == true)
                    count++;

                if (trl2.Trl6_5 == true)
                    count++;

                if (trl2.Trl6_6 == true)
                    count++;

                if (trl2.Trl6_7 == true)
                    count++;

                if (trl2.Trl6_8 == true)
                    count++;

                if (trl2.Trl6_9 == true)
                    count++;

                if (trl2.Trl6_10 == true)
                    count++;




                if (trl2.Trl7_1 == true)
                    count++;

                if (trl2.Trl7_2 == true)
                    count++;

                if (trl2.Trl7_3 == true)
                    count++;

                if (trl2.Trl7_4 == true)
                    count++;




                if (trl2.Trl8_1 == true)
                    count++;

                if (trl2.Trl8_2 == true)
                    count++;

                if (trl2.Trl8_3 == true)
                    count++;

                if (trl2.Trl8_4 == true)
                    count++;



                trl2.TotalCount = count;


                TRLs2.Remove(Trl2);

                TRLs2.Add(trl2);

            }

        }

        public void SaveTRL3(string themeName, int stageId, TRL3 trl3)
        {
            //var Trl = _dbContext.TRLs.FirstOrDefault(x => x.StageName == themeName);

            //Trl.TotalCount = count;

            //_dbContext.SaveChanges();

            var Trl3 = TRLs3.FirstOrDefault(x => x.ThemeName == themeName && x.StageId == stageId);

            if (Trl3 != null)
            {
                if (trl3.Trl1_1 && trl3.Trl1_2 && trl3.Trl1_3 && trl3.Trl1_4 && trl3.Trl1_5 && trl3.Trl1_6 && trl3.Trl1_7 && trl3.Trl1_8)
                {
                    trl3.Trl1 = true;
                }

                if (trl3.Trl2_1 && trl3.Trl2_2 && trl3.Trl2_3 && trl3.Trl2_4 && trl3.Trl2_5 && trl3.Trl2_6 && trl3.Trl2_7 && trl3.Trl2_8 && trl3.Trl2_9
                    && trl3.Trl2_10 && trl3.Trl2_11 && trl3.Trl2_12 && trl3.Trl2_13 && trl3.Trl2_14 && trl3.Trl2_15 && trl3.Trl2_16 && trl3.Trl2_17
                    && trl3.Trl2_18 && trl3.Trl2_19)
                {
                    trl3.Trl2 = true;
                }

                if (trl3.Trl3_1 && trl3.Trl3_2 && trl3.Trl3_3 && trl3.Trl3_4 && trl3.Trl3_5 && trl3.Trl3_6 && trl3.Trl3_7 && trl3.Trl3_8
                    && trl3.Trl3_9 && trl3.Trl3_10 && trl3.Trl3_11 && trl3.Trl3_12 && trl3.Trl3_13 && trl3.Trl3_14)
                {
                    trl3.Trl3x = true;
                }
               
                if (trl3.Trl4_1 && trl3.Trl4_2 && trl3.Trl4_3 && trl3.Trl4_4 && trl3.Trl4_5 && trl3.Trl4_6 && trl3.Trl4_7 && trl3.Trl4_8
                        && trl3.Trl4_9 && trl3.Trl4_10 && trl3.Trl4_11 && trl3.Trl4_12 && trl3.Trl4_13 && trl3.Trl4_14 && trl3.Trl4_15 
                        && trl3.Trl4_16 && trl3.Trl4_17 && trl3.Trl4_18 && trl3.Trl4_19 && trl3.Trl4_20 && trl3.Trl4_21 && trl3.Trl4_22)
                {
                    trl3.Trl4 = true;
                }

                if (trl3.Trl5_1 && trl3.Trl5_2 && trl3.Trl5_3 && trl3.Trl5_4 && trl3.Trl5_5 && trl3.Trl5_6 && trl3.Trl5_7 && trl3.Trl5_8
                        && trl3.Trl5_9 && trl3.Trl5_10 && trl3.Trl5_11 && trl3.Trl5_12 && trl3.Trl5_13 && trl3.Trl5_14 && trl3.Trl5_15 
                        && trl3.Trl5_16 && trl3.Trl5_17 && trl3.Trl5_18 && trl3.Trl5_19 && trl3.Trl5_20 && trl3.Trl5_21 && trl3.Trl5_22)
                {
                    trl3.Trl5 = true;
                }

                if (trl3.Trl6_1 && trl3.Trl6_2 && trl3.Trl6_3 && trl3.Trl6_4 && trl3.Trl6_5 && trl3.Trl6_6 && trl3.Trl6_7 && trl3.Trl6_8 && trl3.Trl6_9 
                    && trl3.Trl6_10 && trl3.Trl6_11 && trl3.Trl6_12 && trl3.Trl6_13 && trl3.Trl6_14 && trl3.Trl6_15 && trl3.Trl6_16 && trl3.Trl6_17 
                    && trl3.Trl6_18 && trl3.Trl6_19 && trl3.Trl6_20 && trl3.Trl6_21 && trl3.Trl6_22 && trl3.Trl6_23 && trl3.Trl6_24 && trl3.Trl6_25)
                {
                    trl3.Trl6 = true;
                }


                if (trl3.Trl7_1 && trl3.Trl7_2 && trl3.Trl7_3 && trl3.Trl7_4 && trl3.Trl7_5 && trl3.Trl7_6 && trl3.Trl7_7 && trl3.Trl7_8)
                {
                    trl3.Trl7 = true;
                }


                if (trl3.Trl8_1 && trl3.Trl8_2 && trl3.Trl8_3 && trl3.Trl8_4 && trl3.Trl8_5 && trl3.Trl8_6 && trl3.Trl8_7 && trl3.Trl8_8 
                    && trl3.Trl8_9 && trl3.Trl8_10 && trl3.Trl8_11)
                {
                    trl3.Trl8 = true;
                }

                if (trl3.Trl9_1 && trl3.Trl9_2 && trl3.Trl9_3 && trl3.Trl9_4 && trl3.Trl9_5 && trl3.Trl9_6 && trl3.Trl9_7 && trl3.Trl9_8 && trl3.Trl9_9)
                {
                    trl3.Trl9 = true;
                }


                int count = 0;

                if (trl3.Trl1_1 == true)
                    count++;

                if (trl3.Trl1_2 == true)
                    count++;

                if (trl3.Trl1_3 == true)
                    count++;

                if (trl3.Trl1_4 == true)
                    count++;

                if (trl3.Trl1_5 == true)
                    count++;

                if (trl3.Trl1_6 == true)
                    count++;

                if (trl3.Trl1_7 == true)
                    count++;

                if (trl3.Trl1_8 == true)
                    count++;


                if (trl3.Trl2_1 == true)
                    count++;

                if (trl3.Trl2_2 == true)
                    count++;

                if (trl3.Trl2_3 == true)
                    count++;

                if (trl3.Trl2_4 == true)
                    count++;

                if (trl3.Trl2_5 == true)
                    count++;

                if (trl3.Trl2_6 == true)
                    count++;

                if (trl3.Trl2_7 == true)
                    count++;

                if (trl3.Trl2_8 == true)
                    count++;

                if (trl3.Trl2_9 == true)
                    count++;

                if (trl3.Trl2_10 == true)
                    count++;

                if (trl3.Trl2_11 == true)
                    count++;

                if (trl3.Trl2_12 == true)
                    count++;

                if (trl3.Trl2_13 == true)
                    count++;

                if (trl3.Trl2_14 == true)
                    count++;

                if (trl3.Trl2_15 == true)
                    count++;

                if (trl3.Trl2_16 == true)
                    count++;

                if (trl3.Trl2_17 == true)
                    count++;

                if (trl3.Trl2_18 == true)
                    count++;

                if (trl3.Trl2_19 == true)
                    count++;



                if (trl3.Trl3_1 == true)
                    count++;

                if (trl3.Trl3_2 == true)
                    count++;

                if (trl3.Trl3_3 == true)
                    count++;

                if (trl3.Trl3_4 == true)
                    count++;

                if (trl3.Trl3_5 == true)
                    count++;

                if (trl3.Trl3_6 == true)
                    count++;

                if (trl3.Trl3_7 == true)
                    count++;

                if (trl3.Trl3_8 == true)
                    count++;

                if (trl3.Trl3_9 == true)
                    count++;

                if (trl3.Trl3_10 == true)
                    count++;

                if (trl3.Trl3_11 == true)
                    count++;

                if (trl3.Trl3_12 == true)
                    count++;

                if (trl3.Trl3_13 == true)
                    count++;

                if (trl3.Trl3_14 == true)
                    count++;



                if (trl3.Trl4_1 == true)
                    count++;

                if (trl3.Trl4_2 == true)
                    count++;

                if (trl3.Trl4_3 == true)
                    count++;

                if (trl3.Trl4_4 == true)
                    count++;

                if (trl3.Trl4_5 == true)
                    count++;

                if (trl3.Trl4_6 == true)
                    count++;

                if (trl3.Trl4_7 == true)
                    count++;

                if (trl3.Trl4_8 == true)
                    count++;

                if (trl3.Trl4_9 == true)
                    count++;

                if (trl3.Trl4_10 == true)
                    count++;

                if (trl3.Trl4_11 == true)
                    count++;

                if (trl3.Trl4_12 == true)
                    count++;

                if (trl3.Trl4_13 == true)
                    count++;

                if (trl3.Trl4_14 == true)
                    count++;

                if (trl3.Trl4_15 == true)
                    count++;

                if (trl3.Trl4_16 == true)
                    count++;

                if (trl3.Trl4_17 == true)
                    count++;

                if (trl3.Trl4_18 == true)
                    count++;

                if (trl3.Trl4_19 == true)
                    count++;

                if (trl3.Trl4_20 == true)
                    count++;

                if (trl3.Trl4_21 == true)
                    count++;

                if (trl3.Trl4_22 == true)
                    count++;


                if (trl3.Trl5_1 == true)
                    count++;

                if (trl3.Trl5_2 == true)
                    count++;

                if (trl3.Trl5_3 == true)
                    count++;

                if (trl3.Trl5_4 == true)
                    count++;

                if (trl3.Trl5_5 == true)
                    count++;

                if (trl3.Trl5_6 == true)
                    count++;

                if (trl3.Trl5_7 == true)
                    count++;

                if (trl3.Trl5_8 == true)
                    count++;

                if (trl3.Trl5_9 == true)
                    count++;

                if (trl3.Trl5_10 == true)
                    count++;

                if (trl3.Trl5_11 == true)
                    count++;

                if (trl3.Trl5_12 == true)
                    count++;

                if (trl3.Trl5_13 == true)
                    count++;

                if (trl3.Trl5_14 == true)
                    count++;

                if (trl3.Trl5_15 == true)
                    count++;

                if (trl3.Trl5_16 == true)
                    count++;

                if (trl3.Trl5_17 == true)
                    count++;

                if (trl3.Trl5_18 == true)
                    count++;

                if (trl3.Trl5_19 == true)
                    count++;

                if (trl3.Trl5_20 == true)
                    count++;

                if (trl3.Trl5_21 == true)
                    count++;

                if (trl3.Trl5_22 == true)
                    count++;




                if (trl3.Trl6_1 == true)
                    count++;

                if (trl3.Trl6_2 == true)
                    count++;

                if (trl3.Trl6_3 == true)
                    count++;

                if (trl3.Trl6_4 == true)
                    count++;

                if (trl3.Trl6_5 == true)
                    count++;

                if (trl3.Trl6_6 == true)
                    count++;

                if (trl3.Trl6_7 == true)
                    count++;

                if (trl3.Trl6_8 == true)
                    count++;

                if (trl3.Trl6_9 == true)
                    count++;

                if (trl3.Trl6_10 == true)
                    count++;

                if (trl3.Trl6_11 == true)
                    count++;

                if (trl3.Trl6_12 == true)
                    count++;

                if (trl3.Trl6_13 == true)
                    count++;

                if (trl3.Trl6_14 == true)
                    count++;

                if (trl3.Trl6_15 == true)
                    count++;

                if (trl3.Trl6_16 == true)
                    count++;

                if (trl3.Trl6_17 == true)
                    count++;

                if (trl3.Trl6_18 == true)
                    count++;

                if (trl3.Trl6_19 == true)
                    count++;

                if (trl3.Trl6_20 == true)
                    count++;

                if (trl3.Trl6_21 == true)
                    count++;

                if (trl3.Trl6_22 == true)
                    count++;

                if (trl3.Trl6_23 == true)
                    count++;

                if (trl3.Trl6_24 == true)
                    count++;

                if (trl3.Trl6_25 == true)
                    count++;

               

                if (trl3.Trl7_1 == true)
                    count++;

                if (trl3.Trl7_2 == true)
                    count++;

                if (trl3.Trl7_3 == true)
                    count++;

                if (trl3.Trl7_4 == true)
                    count++;

                if (trl3.Trl7_5 == true)
                    count++;

                if (trl3.Trl7_6 == true)
                    count++;

                if (trl3.Trl7_7 == true)
                    count++;

                if (trl3.Trl7_8 == true)
                    count++;




                if (trl3.Trl8_1 == true)
                    count++;

                if (trl3.Trl8_2 == true)
                    count++;

                if (trl3.Trl8_3 == true)
                    count++;

                if (trl3.Trl8_4 == true)
                    count++;

                if (trl3.Trl8_5 == true)
                    count++;

                if (trl3.Trl8_6 == true)
                    count++;

                if (trl3.Trl8_7 == true)
                    count++;

                if (trl3.Trl8_8 == true)
                    count++;

                if (trl3.Trl8_9 == true)
                    count++;

                if (trl3.Trl8_10 == true)
                    count++;

                if (trl3.Trl8_11 == true)
                    count++;


                if (trl3.Trl9_1 == true)
                    count++;

                if (trl3.Trl9_2 == true)
                    count++;

                if (trl3.Trl9_3 == true)
                    count++;

                if (trl3.Trl9_4 == true)
                    count++;

                if (trl3.Trl9_5 == true)
                    count++;

                if (trl3.Trl9_6 == true)
                    count++;

                if (trl3.Trl9_7 == true)
                    count++;

                if (trl3.Trl9_8 == true)
                    count++;

                if (trl3.Trl9_9 == true)
                    count++;



                trl3.TotalCount = count;


                TRLs3.Remove(Trl3);

                TRLs3.Add(trl3);

            }

        }


        public TRL1 GetTrls1(string themeName, int stageId)
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
                TRL1 trl1 = new TRL1(themeName, stageId, 0);
                TRLs1.Add(trl1);
                return trl1;
            }

            else
            {
                var existing = TRLs1.FirstOrDefault(x => x.ThemeName == themeName && x.StageId == stageId);

                if (existing == null)
                {
                    TRL1 trl1 = new TRL1(themeName, stageId, 0);
                    TRLs1.Add(trl1);
                    return trl1;
                }

                else
                {
                    return existing;
                }
            }


        }


        public TRL2 GetTrls2(string themeName, int stageId)
        {

            if (TRLs2.Count == 0)
            {
                TRL2 trl2 = new TRL2(themeName, stageId, 0);
                TRLs2.Add(trl2);
                return trl2;
            }

            else
            {
                var existing = TRLs2.FirstOrDefault(x => x.ThemeName == themeName && x.StageId == stageId);

                if (existing == null)
                {
                    TRL2 trl2 = new TRL2(themeName, stageId, 0);
                    TRLs2.Add(trl2);
                    return trl2;
                }

                else
                {
                    return existing;
                }
            }


        }

        public TRL3 GetTrls3(string themeName, int stageId)
        {

            if (TRLs3.Count == 0)
            {
                TRL3 trl3 = new TRL3(themeName, stageId, 0);
                TRLs3.Add(trl3);
                return trl3;
            }

            else
            {
                var existing = TRLs3.FirstOrDefault(x => x.ThemeName == themeName && x.StageId == stageId);

                if (existing == null)
                {
                    TRL3 trl3 = new TRL3(themeName, stageId, 0);
                    TRLs3.Add(trl3);
                    return trl3;
                }

                else
                {
                    return existing;
                }
            }


        }

    }
}
