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
                new Stage(1, 1, "1", "Этап 1"),
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


            if (Stages.Any(x => x.StageName == stage.StageName))
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

            existing.StageNumber = stage.StageNumber;
            existing.StageName = stage.StageName;
            existing.WorkStart = stage.WorkStart;
            existing.WorkEnd = stage.WorkEnd;
            existing.Amount = stage.Amount;
            existing.CompletionAct = stage.CompletionAct;
            existing.Status = stage.Status;
        }

        public void DeleteStage(int id)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            //var person = _dbContext.Persons.FirstOrDefault(x => x.Id == id);

            //if (existing == null)
            //    return;

            //_dbContext.Users.Remove(existing);
            //_dbContext.Persons.Remove(person);

            //_dbContext.SaveChanges();

            var existing = Stages.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;

            Stages.Remove(existing);
        }

    }
}
