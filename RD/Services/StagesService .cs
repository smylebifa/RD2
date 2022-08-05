using RD.Data;
using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RD.Services
{
    public class StagesService : IStagesService
    {
        private readonly TestDbContext _dbContext;

        public StagesService(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Stage> GetStages()
        {
            return _dbContext.Stages.ToArray();
        }

        public void AddStage(Stage stage)
        {
            if (_dbContext.Stages.Any(x => x.NumStage == stage.NumStage))
                throw new ArgumentException("User with such name already exists.");

            _dbContext.Stages.Add(stage);

            _dbContext.SaveChanges();
        }

       

    }
}
