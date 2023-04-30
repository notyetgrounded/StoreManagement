using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreManagement.Domain.Models.Inventory;

namespace StoreManagement.Repository.Configurations
{
    public class InventoryConfiguration : IEntityTypeConfiguration<InventoryModel>
    {
        public void Configure(EntityTypeBuilder<InventoryModel> builder)
        {
            builder.HasIndex(b => b.Name).IsUnique();
        }
    }
}
