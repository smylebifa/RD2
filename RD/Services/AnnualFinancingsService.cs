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
            if (AnnualFinancings.Any(x => x.Id == annualFinancing.Id))
                throw new ArgumentException("Theme with such login already exists.");

            AnnualFinancings.Add(annualFinancing);

            //if (_dbContext.Themes.Any(x => x.Name == theme.Name))
            //    throw new ArgumentException("Theme with such name already exists.");

            //_dbContext.Themes.Add(theme);

            //_dbContext.SaveChanges();
        }

        public void UpdateAnnualFinancing(AnnualFinancing annualFinancing)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == user.Id);

            //if (existing == null)
            //    return;

            //existing.Login = user.Login;
            //existing.Password = user.Password;
            //existing.IsActive= true;

            //_dbContext.SaveChanges();

            //var existing = Themes.FirstOrDefault(x => x.Id == theme.Id);
            //if (existing == null)
            //    return;

            //existing.Name = theme.Name;
            //existing.Number = theme.Number;
            //existing.FioManager = theme.FioManager;
            //existing.ExecutiveDepartment = theme.ExecutiveDepartment;
            //existing.WorkStart = theme.WorkStart;
            //existing.WorkEnd = theme.WorkEnd;
            //existing.Amount = theme.Amount;
            //existing.Vat = theme.Vat;
            //existing.AmountWithoutVat = theme.AmountWithoutVat;
            //existing.Decree = theme.Decree;
            //existing.DocType = theme.DocType;
            //existing.Props = theme.Props;
            //existing.ResearchType = theme.ResearchType;
            //existing.Knowledge = theme.Knowledge;
            //existing.Status = theme.Status;
            //existing.Props = theme.Props;

        }
        public AnnualFinancing GetAnnualFinancingById(int theme_id)
        {

            var existing = AnnualFinancings.FirstOrDefault(x => x.ThemeId == theme_id);
            //return _dbContext.Themes.ToArray();

            return existing;            
        }

       

       

    }
}
