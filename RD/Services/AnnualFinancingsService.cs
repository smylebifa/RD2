using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Services
{
    public class AnnualFinancingsService
    {
        private static readonly List<AnnualFinancing> AnnualFinancings = new List<AnnualFinancing>
        {
                new AnnualFinancing(1, 1, 2020, 50000),
        };

        public IEnumerable<AnnualFinancing> GetAnnualFinancings()
        {
            return AnnualFinancings;
            //return _dbContext.Themes.ToArray();
        }

        public void AddAnnualFinancing(AnnualFinancing annualFinancing)
        {
            //if (AnnualFinancings.Any(x => x.Id == annualFinancing.Id))
            //    throw new ArgumentException("Theme with such login already exists.");

            int LastId = AnnualFinancings.Max(annualFinancings => annualFinancings.Id);
            
            if (LastId is int)
            {
                annualFinancing.Id = LastId + 1;
                AnnualFinancings.Add(annualFinancing);
            }
           

            //if (_dbContext.Themes.Any(x => x.Name == theme.Name))
            //    throw new ArgumentException("Theme with such name already exists.");

            //_dbContext.Themes.Add(theme);

            //_dbContext.SaveChanges();
        }

        public void UpdateAnnualFinancing(AnnualFinancing annualFinancing)
        {
            var existing = AnnualFinancings.FirstOrDefault(x => x.Id == annualFinancing.Id);
            if (existing == null)
                return;

            existing.Year = annualFinancing.Year;
            existing.Amount = annualFinancing.Amount;

        }
        public AnnualFinancing GetAnnualFinancingById(int theme_id)
        {

            var existing = AnnualFinancings.FirstOrDefault(x => x.ThemeId == theme_id);
            //return _dbContext.Themes.ToArray();

            return existing;            
        }

        public void DeleteAnnualFinancing(int id)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            //var person = _dbContext.Persons.FirstOrDefault(x => x.Id == id);

            //if (existing == null)
            //    return;

            //_dbContext.Users.Remove(existing);
            //_dbContext.Persons.Remove(person);

            //_dbContext.SaveChanges();

            var existing = AnnualFinancings.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            AnnualFinancings.Remove(existing);
        }

    }
}
