using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Services
{
    public interface IThemesService
    {
        public IEnumerable<Theme> GetThemes();

        public bool AddTheme(Theme theme);
        
    }
}
