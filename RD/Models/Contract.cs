using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public int CounterpartyId { get; set; }
        public string? NameContract { get; set; }
        public DateTime? WorkStart { get; set; }
        public DateTime? WorkEnd { get; set; }
        public string? Props { get; set; }
        public float? Amount { get; set; }
        public string? Status { get; set; }

        public Contract()
        {
            Id = 1;
        }

        public Contract(int id, string nameContract)
        {
            Id = id;
            NameContract = nameContract;
        }

        public Contract(int id, string nameContract, float amount, string status)
        {
            Id = id;
            NameContract = nameContract;
            Amount = amount;
            Status = Status;
        }
    }
}
