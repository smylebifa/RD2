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
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<Theme> Themes { get; set; } = null!;
        public DbSet<TRL> TRLs { get; set; } = null!;        
        public DbSet<Stage> Stages { get; set; } = null!;
    }
}
