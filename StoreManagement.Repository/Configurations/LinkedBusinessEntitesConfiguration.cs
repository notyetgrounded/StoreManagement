using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreManagement.Domain.Models.BusinessEntity;

namespace StoreManagement.Repository.Configurations
{
    internal class LinkedBusinessEntitesConfiguration : IEntityTypeConfiguration<LinkedBusinessEntitesModel>
    {
        public void Configure(EntityTypeBuilder<LinkedBusinessEntitesModel> builder)
        {
            builder.HasOne(lb => lb.ParentBusinessEntity).WithMany(lb => lb.LinkedParentBuisnessEntities).HasForeignKey(lb => lb.ParentBusinessEntityId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(lb => lb.ChildBusinessEntity).WithMany(lb => lb.LinkedChildBuisnessEntities).HasForeignKey(lb => lb.ChildBusinessEntityId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
