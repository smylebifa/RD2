using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class Stage
    {
        public Guid Id { get; set; }
        public string? NumStage { get; set; }
        public DateTime? WorkStart { get; set; }
        public DateTime? WorkEnd { get; set; }
        public int? Amount { get; set; }
        public string? CompletionAct { get; set; }
        public string? Status { get; set; }
        
        public Guid? CounterpartyId { get; set; }
        public Guid? ContractId { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Stage(Guid id, string? numStage)
        {
            Id = id;
            NumStage = numStage;
        }

        public Stage()
        {
            Id = Guid.NewGuid();
        }
    }
}
