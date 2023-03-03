using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DatabaseContext
{
    public class DrugDbContextFactory : IDesignTimeDbContextFactory<DrugDbContext>
    {
        public DrugDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<DrugDbContext>();
            options.UseNpgsql(@"Host=localhost;Port=5432;Database=Drugs;Username=postgres;Password=postgres");
            return new DrugDbContext(options.Options);
        }
    }
}
