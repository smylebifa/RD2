using RD.Data;
using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Services
{
    public class TRLsService : ITRLsService
    {
        private readonly TestDbContext _dbContext;

        public TRLsService(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Save(string themeName, bool? trl1_1, bool? trl1_2, bool? trl1_3, bool? trl1_4, bool? trl1_5,
            bool? trl2_1, bool? trl2_2, bool? trl2_3, bool? trl2_4, bool? trl2_5)
        {
            var Trl = _dbContext.TRLs.FirstOrDefault(x => x.StageName == themeName);

            Trl.Trl1_1 = trl1_1;
            Trl.Trl1_2 = trl1_2;
            Trl.Trl1_3 = trl1_3;
            Trl.Trl1_4 = trl1_4;
            Trl.Trl1_5 = trl1_5;
            Trl.Trl2_1 = trl2_1;
            Trl.Trl2_2 = trl2_2;
            Trl.Trl2_3 = trl2_3;
            Trl.Trl2_4 = trl2_4;
            Trl.Trl2_5 = trl2_5;

            int count = 0;

            if (trl1_1 == true)
                count++;
            if (trl1_2 == true)
                count++;
            if (trl1_3 == true)
                count++;
            if (trl1_4 == true)
                count++;
            if (trl1_5 == true)
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

            Trl.TotalReady = count;

            _dbContext.SaveChanges();
        }

        public TRL GetTrls(string themeName)
        {
            var existing = _dbContext.TRLs.FirstOrDefault(x => x.StageName == themeName);

            if (existing == null)
            {
                TRL trl = new TRL(themeName, false, false, false, false, false, false, false, false, false, false, 0);
                _dbContext.Add(trl);
                _dbContext.SaveChanges();
                return trl;
            }
            else
            {
                return existing;
            }
        }


    }
}
