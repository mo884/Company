
using Company.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Company.DAL.Database
{
    public class ApplicationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=CompanyNTier;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Branch> Branchs { get; set; }

    }
}
