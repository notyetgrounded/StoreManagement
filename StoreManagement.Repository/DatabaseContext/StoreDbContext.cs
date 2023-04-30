using Microsoft.EntityFrameworkCore;
using StoreManagement.Domain.Models.BusinessEntity;
using StoreManagement.Domain.Models.Employee;
using StoreManagement.Domain.Models.Inventory;
using StoreManagement.Domain.Models.Permissions;
using StoreManagement.Domain.Models.Product;
using StoreManagement.Domain.Models.Purchase;
using StoreManagement.Domain.Models.User;
using StoreManagement.Repository.Configurations;

namespace StoreManagement.Repository.DatabaseContext
{
    public class StoreDbContext : DbContext
    {
        public DbSet<BusinessEntityModel> BusinessEntities { get; set; }
        public DbSet<PermissionModel> Permissions { get; set; }
        public DbSet<SecurityRoleAssociationModel> SecurityRoleAssociations { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<PurchaseModel> Purchases { get; set; }
        public DbSet<PurchaseProductModel> PurchaseProducts { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<InventoryModel> Inventories { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<LinkedBusinessEntitesModel> LinkedBusinessEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BusinessEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new PurchaseProductConfiguration());
            modelBuilder.ApplyConfiguration(new SecurityRoleAssociationConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PurchaseConfiguration());
            modelBuilder.ApplyConfiguration(new InventoryConfiguration());
        }

        public StoreDbContext(DbContextOptions<StoreDbContext> options): base(options)
        {
            
        }
    }
}
