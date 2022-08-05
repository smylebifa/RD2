using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Services
{
    public interface ITRLsService
    {
        public void Save(string themeName, bool? trl1_1, bool? trl1_2, bool? trl1_3, bool? trl1_4, bool? trl1_5,
            bool? trl2_1, bool? trl2_2, bool? trl2_3, bool? trl2_4, bool? trl2_5);
        public TRL GetTrls(string themeName);
    }
}
