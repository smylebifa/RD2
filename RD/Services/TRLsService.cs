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
        public void Save(TRL trl)
        {
            //_dbContext.TRLs.Add(trl);

            var existing = _dbContext.TRLs.FirstOrDefault(x => x.StageName == trl.StageName);

            if (existing == null)
                return;

            existing.Trl1 = trl.Trl1;
            existing.Trl2 = trl.Trl2;

            _dbContext.SaveChanges();
        }

        public TRL GetTrls()
        {
            return _dbContext.TRLs.ToArray().FirstOrDefault(x => x.StageName == "a"); 
        }
        

    }
}
