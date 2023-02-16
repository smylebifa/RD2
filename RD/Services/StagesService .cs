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
                new Stage(5, "Этап 5"),
                new Stage(6, "Этап 6"),
                new Stage(7, "Этап 7"),
                new Stage(8, "Этап 8"),
                new Stage(9, "Этап 9"),
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

        public void UpdateStage(Stage stage)
        {
            //if (_dbContext.Stages.Any(x => x.NumStage == stage.NumStage))
            //    throw new ArgumentException("User with such name already exists.");

            //_dbContext.Stages.Add(stage);

            //_dbContext.SaveChanges();


            var existing = Stages.FirstOrDefault(x => x.Id == stage.Id);
            if (existing == null)
                return;

            existing.WorkStart = stage.WorkStart;
            existing.WorkEnd = stage.WorkEnd;
            existing.Amount = stage.Amount;
            existing.CompletionAct = stage.CompletionAct;
            existing.Status = stage.Status;
        }

    }
}
