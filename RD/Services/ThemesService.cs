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
    public class ThemesService : IThemesService
    {
        //private readonly TestDbContext _dbContext;

        //public ThemesService(TestDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        private static readonly List<Theme> Themes = new List<Theme>
        {
                new Theme(1, "Тема 1"),
        };

        public IEnumerable<Theme> GetThemes()
        {
            return Themes;
            //return _dbContext.Themes.ToArray();
        }

        public void AddTheme(Theme theme)
        {
            if (Themes.Any(x => x.Name == theme.Name))
                throw new ArgumentException("Theme with such login already exists.");

            Themes.Add(theme);

            //if (_dbContext.Themes.Any(x => x.Name == theme.Name))
            //    throw new ArgumentException("Theme with such name already exists.");

            //_dbContext.Themes.Add(theme);

            //_dbContext.SaveChanges();
        }

        public void UpdateTheme(Theme theme)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == user.Id);

            //if (existing == null)
            //    return;

            //existing.Login = user.Login;
            //existing.Password = user.Password;
            //existing.IsActive= true;

            //_dbContext.SaveChanges();

            var existing = Themes.FirstOrDefault(x => x.Id == theme.Id);
            if (existing == null)
                return;

            existing.Name = theme.Name;
            existing.Number = theme.Number;
            existing.FioManager = theme.FioManager;
            existing.ExecutiveDepartment = theme.ExecutiveDepartment;
            existing.CustomerName = theme.CustomerName;
            existing.WorkStart = theme.WorkStart;
            existing.WorkEnd = theme.WorkEnd;
            existing.Amount = theme.Amount;
            existing.Vat = theme.Vat;
            existing.AmountWithoutVat = theme.AmountWithoutVat;
            existing.Decree = theme.Decree;
            existing.DocType = theme.DocType;
            existing.Props = theme.Props;
            existing.ResearchType = theme.ResearchType;
            existing.Knowledge = theme.Knowledge;
            existing.Status = theme.Status;
            existing.Props = theme.Props;

        }

        public void DeleteTheme(int id)
        {
            //var existing = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            //var person = _dbContext.Persons.FirstOrDefault(x => x.Id == id);

            //if (existing == null)
            //    return;

            //_dbContext.Users.Remove(existing);
            //_dbContext.Persons.Remove(person);

            //_dbContext.SaveChanges();

            var existing = Themes.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            Themes.Remove(existing);
        }



    }
}
