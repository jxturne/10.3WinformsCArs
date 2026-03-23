using _10._3WinformsCArs.Cars;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _10._3WinformsCArs.Data
{
    public class CarsContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-VV074IR;initial catalog=CarDB;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }
        // data seeding

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { VIN = "1HGBH41JXMN109186", Make = "Toyota", Model = "Camry", Year = 2020, Price = 24000 },
                new Car { VIN = "2HGBH41JXMN109187", Make = "Honda", Model = "Civic", Year = 2019, Price = 22000 },
                new Car { VIN = "3HGBH41JXMN109188", Make = "Ford", Model = "Mustang", Year = 2021, Price = 35000 },
                new Car { VIN = "4HGBH41JXMN109189", Make = "Chevy", Model = "Blazer", Year = 2018, Price = 18000 }
            );
                
              

        }
    }
}
