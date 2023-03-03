using DataBase.DatabaseContext;
using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Manufacturer manufacturer1 = new()
        {
            Name = "ООО Мегалюль",
            Drug = new Drug() { Name = "Спик", Stock = new Stock() { Name = "Склад на Донбассе" } }
        };
        Stock stock2 = new()
        {
            Name = "Тест2"
        };
        Drug drug2 = new()
        {
            Name = "Тестомедрон3",
            Stock = new Stock() { Name = "Склад на Донбассе" }
        };
        Manufacturer manufacturer2 = new()
        {
            Name = "ООО Тест2",
            Drug = drug2,
        };


        using (var dbContext = new DrugDbContextFactory().CreateDbContext())
        {
            //dbContext.Stock.Add(stock2);
            //dbContext.Drug.Add(drug2);
            //dbContext.Manufacturer.Add(manufacturer2);
            //dbContext.Manufacturer.Add(manufacturer1);
            //dbContext.SaveChanges();
            var stocks = dbContext.Stock.Include(u => u.Drugs).ThenInclude(c => c.Manufacturer).ToList();
            //if (dbContext.Stock.Any(x=>x.Name == searchingStock))
            //{
            foreach (var s in stocks)
            {
                Console.WriteLine($"На складе {s.Name} хранятся:");

                foreach (var d in s.Drugs)
                {
                    Console.WriteLine($"\t-{d.Name}");
                    foreach (var m in d.Manufacturer)
                    {
                        Console.WriteLine($"\t\t-{m.Name}");
                    }
                }



                //}
                Console.WriteLine("_______________________________");
            }
        }
    }
}