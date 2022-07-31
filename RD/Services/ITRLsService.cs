using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Services
{
    public interface ITRLsService
    {
        public void Save(TRL trl);
        public TRL GetTrls();
    }
}
