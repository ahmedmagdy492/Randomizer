using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.Models
{
    public class AppDBContext : DbContext
    {
        private string? path;
        public AppDBContext()
        {
            path = Path.Join(Environment.CurrentDirectory, "randomizer.db");
        }

        public DbSet<Thing>? Things { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={path}");
    }
}
