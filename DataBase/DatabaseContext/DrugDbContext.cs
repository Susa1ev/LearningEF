using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DatabaseContext
{
    public class DrugDbContext : DbContext
    {
        public DrugDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            Database.EnsureCreated();
        }
        public DbSet<Drug> Drug { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
    }
}
