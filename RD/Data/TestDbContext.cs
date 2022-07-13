using Microsoft.EntityFrameworkCore;
using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Data
{
    public class TestDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
    }
}
