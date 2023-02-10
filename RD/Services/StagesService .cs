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
        //private readonly TestDbContext _dbContext;

        //public StagesService(TestDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        private static readonly List<Stage> Stages = new List<Stage>
        {
                new Stage(1, "Этап 1"),
                new Stage(2, "Этап 2"),
                new Stage(3, "Этап 3"),
                new Stage(4, "Этап 4"),
        };

        public IEnumerable<Stage> GetStages()
        {
            return Stages;
            //return _dbContext.Stages.ToArray();
        }

        public void AddStage(Stage stage)
        {
            //if (_dbContext.Stages.Any(x => x.NumStage == stage.NumStage))
            //    throw new ArgumentException("User with such name already exists.");

            //_dbContext.Stages.Add(stage);

            //_dbContext.SaveChanges();


            if (Stages.Any(x => x.NumStage == stage.NumStage))
                throw new ArgumentException("This stage already exists.");

            Stages.Add(stage);
        }       

    }
}
