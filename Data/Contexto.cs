using Microsoft.EntityFrameworkCore;
using ParcialAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcialAplicada2.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Inscripcions> Inscripcions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source = Database\ExameDb.db");
        }
    }
}
