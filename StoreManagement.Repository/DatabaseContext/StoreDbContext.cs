using Microsoft.EntityFrameworkCore;
using StoreManagement.Domain.Models.BusinessEntity;
using StoreManagement.Repository.Configurations;

namespace StoreManagement.Repository.DatabaseContext
{
    public class StoreDbContext : DbContext
    {
        public DbSet<BusinessEntityModel> BusinessEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BusinessEntityConfiguration());
        }
    }
}
