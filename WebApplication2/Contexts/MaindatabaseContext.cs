using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Contexts
{
    public class MaindatabaseContext :DbContext
    {
        private readonly string _connectionString = @"Server=DESKTOP-GTVND9D\SQLEXPRESS;Database=FiorellaDB;Trusted_Connection=True;TrustserverCertificate=True;";
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }



    }
}
