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

        private static readonly List<TRL1> TRLs1 = new List<TRL1>
        {
                new TRL1(),
        };


        public void SaveTRL1(string themeName, bool trl1_1, bool trl1_2, bool trl1_3, bool trl1_4,
            bool trl2_1, bool trl2_2, bool trl2_3, bool trl2_4, bool trl2_5, bool trl2_6, bool trl2_7, bool trl2_8, bool trl2_9)
        {
            //var Trl = _dbContext.TRLs.FirstOrDefault(x => x.StageName == themeName);

            //Trl.Trl1_1 = trl1_1;
            //Trl.Trl1_2 = trl1_2;
            //Trl.Trl1_3 = trl1_3;
            //Trl.Trl1_4 = trl1_4;
            //Trl.Trl1_5 = trl1_5;
            //Trl.Trl2_1 = trl2_1;
            //Trl.Trl2_2 = trl2_2;
            //Trl.Trl2_3 = trl2_3;
            //Trl.Trl2_4 = trl2_4;
            //Trl.Trl2_5 = trl2_5;

            //int count = 0;

            //if (trl1_1 == true)
            //    count++;
            //if (trl1_2 == true)
            //    count++;
            //if (trl1_3 == true)
            //    count++;
            //if (trl1_4 == true)
            //    count++;
            //if (trl1_5 == true)
            //    count++;
            //if (trl2_1 == true)
            //    count++;
            //if (trl2_2 == true)
            //    count++;
            //if (trl2_3 == true)
            //    count++;
            //if (trl2_4 == true)
            //    count++;
            //if (trl2_5 == true)
            //    count++;

            //Trl.TotalReady = count;

            //_dbContext.SaveChanges();

            var Trl = TRLs1.FirstOrDefault(x => x.ThemeName == themeName);

            if (Trl != null)
            {
                Trl.Trl1[0] = trl1_1;
                Trl.Trl1[1] = trl1_2;
                Trl.Trl1[2] = trl1_3;
                Trl.Trl1[3] = trl1_4;
                
                Trl.Trl2[0] = trl2_1;
                Trl.Trl2[1] = trl2_2;
                Trl.Trl2[2] = trl2_3;
                Trl.Trl2[3] = trl2_4;
                Trl.Trl2[4] = trl2_5;
                Trl.Trl2[5] = trl2_6;
                Trl.Trl2[6] = trl2_7;
                Trl.Trl2[7] = trl2_8;
                Trl.Trl2[8] = trl2_9;


                //Trl.Trl1_2 = trl1_2;
                //Trl.Trl1_3 = trl1_3;
                //Trl.Trl1_4 = trl1_4;
                //Trl.Trl1_5 = trl1_5;
                //Trl.Trl2_1 = trl2_1;
                //Trl.Trl2_2 = trl2_2;
                //Trl.Trl2_3 = trl2_3;
                //Trl.Trl2_4 = trl2_4;
                //Trl.Trl2_5 = trl2_5;

                int count = 0;

                if (trl1_1 == true)
                    count++;
                if (trl1_2 == true)
                    count++;
                if (trl1_3 == true)
                    count++;
                if (trl1_4 == true)
                    count++;
                
                if (trl2_1 == true)
                    count++;
                if (trl2_2 == true)
                    count++;
                if (trl2_3 == true)
                    count++;
                if (trl2_4 == true)
                    count++;
                if (trl2_5 == true)
                    count++;
                if (trl2_6 == true)
                    count++;
                if (trl2_7 == true)
                    count++;
                if (trl2_8 == true)
                    count++;
                if (trl2_9 == true)
                    count++;

                Trl.TotalCount = count;

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

            var existing = TRLs1.FirstOrDefault(x => x.ThemeName == themeName);

            if (existing == null)
            {
                TRL1 trl = new TRL1(themeName, 0);
                TRLs1.Add(trl);
                return trl;
            }

            else
            {
                return existing;
            }
        }      
       

    }
}
