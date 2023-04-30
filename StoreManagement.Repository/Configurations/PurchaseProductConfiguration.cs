using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreManagement.Domain.Models.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Repository.Configurations
{
    internal class PurchaseProductConfiguration: IEntityTypeConfiguration<PurchaseProductModel>
    {
        public void Configure(EntityTypeBuilder<PurchaseProductModel> builder) 
        {
            builder.HasIndex(pp => new { pp.ProductId, pp.PurchaseId }).IsUnique();
        }
    }
}
