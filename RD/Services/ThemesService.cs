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



    }
}
