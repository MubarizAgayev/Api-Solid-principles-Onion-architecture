using Domain.Confirugations;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 


            modelBuilder.Entity<Employee>().HasData(
                  new Employee
                  {
                      Id = 1,
                      FullName = "Ceyhun Yusifli",
                      Address = "Buzovna",
                      Age = 23,
                  },

                   new Employee
                   {
                       Id = 2,
                       FullName = "Mubariz Agayev",
                       Address = "Nizami",
                       Age = 18,
                   },

                    new Employee
                    {
                        Id = 3,
                        FullName = "Shaig Kazimova",
                        Address = "Sedmoy",
                        Age = 25,
                    });

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Azerbaycan"
                },
                new Country
                {
                    Id = 2,
                    Name = "Turkiye"
                }, new Country
                {
                    Id = 3,
                    Name = "Gurcustan"
                });

        }
    }
}
