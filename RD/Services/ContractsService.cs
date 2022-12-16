using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RD.Services
{
    public class ContractsService
    {

        public static List<Contract> Contracts = new List<Contract>
        {
                new Contract(1, "Договор 1", 50000, ""),
        };

        public IEnumerable<Contract> GetContracts()
        {
            return Contracts;
            
        }

        public void AddContract(Contract contract)
        {
            if (Contracts.Any(x => x.NameContract == contract.NameContract))
                throw new ArgumentException("Contract with such name already exists.");

            int LastId = Contracts.Max(contract => contract.Id);
            if (LastId is int)
            {
                contract.Id = LastId + 1;
                
                Contracts.Add(contract);
            }
         
        }

        public void UpdateContract(Contract contract)
        {           
            var existing = Contracts.FirstOrDefault(x => x.Id == contract.Id);
            if (existing == null)
                return;
            existing.NameContract = contract.NameContract;
            existing.Props = contract.Props;
            existing.Status = contract.Status;
            existing.WorkStart = contract.WorkStart;
            existing.WorkEnd = contract.WorkEnd;
        }

        public void DeleteContract(int id)
        {           
            var existing = Contracts.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            Contracts.Remove(existing);
        }
    }
}
