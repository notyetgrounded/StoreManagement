using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreManagement.Domain.Models.BusinessEntity;

namespace StoreManagement.Repository.Configurations
{
    internal class LinkedBusinessEntitesConfiguration : IEntityTypeConfiguration<LinkedBusinessEntitesModel>
    {
        public void Configure(EntityTypeBuilder<LinkedBusinessEntitesModel> builder)
        {
        }
    }
}
