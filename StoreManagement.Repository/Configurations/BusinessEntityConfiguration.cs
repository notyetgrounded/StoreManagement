using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreManagement.Domain.Models.BusinessEntity;

namespace StoreManagement.Repository.Configurations
{
    internal class BusinessEntityConfiguration : IEntityTypeConfiguration<BusinessEntityModel>
    {
        public void Configure(EntityTypeBuilder<BusinessEntityModel> builder)
        {
            builder.HasIndex(b => b.Name).IsUnique();
        }
    }
}
