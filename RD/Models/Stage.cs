using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class Stage
    {
        public int Id { get; set; }
        public string? StageNumber { get; set; }
        public string? StageName { get; set; }
        public DateTime? WorkStart { get; set; }
        public DateTime? WorkEnd { get; set; }
        public int? Amount { get; set; }
        public string? CompletionAct { get; set; }
        public string? Status { get; set; }
        
        public int? CounterpartyId { get; set; }
        public int? ContractId { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Stage(int id, string? stageName)
        {
            Id = id;
            StageName = stageName;
        }

        public Stage(int id, string? stageNumber, string? stageName)
        {
            Id = id;
            StageNumber = stageNumber;
            StageName = stageName;
        }

        public Stage()
        {
            //Id = Guid.NewGuid();
        }
    }
}
