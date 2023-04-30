using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreManagement.Domain.Models.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Repository.Configurations
{
    internal class SecurityRoleAssociationConfiguration : IEntityTypeConfiguration<SecurityRoleAssociationModel>
    {
        public void Configure(EntityTypeBuilder<SecurityRoleAssociationModel> builder)
        {
            builder.HasIndex(sr => new { sr.UserId, sr.PermissionId, sr.BusinessEntityId }).IsUnique();
        }
    }
}
