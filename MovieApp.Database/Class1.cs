using Microsoft.EntityFrameworkCore;
using MovieApp.Database.DataModels;

namespace MovieApp.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=.;Initial Catalog=MovieDB; USER ID=sa; password=P@55w0rd;TrustServerCertificate=True";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}