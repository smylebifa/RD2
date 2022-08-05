using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Services
{
    public interface IStagesService
    {
        public IEnumerable<Stage> GetStages();

        public void AddStage(Stage stage);
        
    }
}
