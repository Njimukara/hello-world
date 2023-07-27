using Microsoft.EntityFrameworkCore;
using NewHelloWorld.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHelloWorld.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            
        }

        public DbSet<Meal> Meals { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Staff> Staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=.;Initial Catalog=RestaurantDB; USER ID=sa; password=P@55w0rd;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
