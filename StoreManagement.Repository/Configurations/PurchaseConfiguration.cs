using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreManagement.Domain.Models.BusinessEntity;
using StoreManagement.Domain.Models.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Repository.Configurations
{
    public class PurchaseConfiguration : IEntityTypeConfiguration<PurchaseModel>
    {
        public void Configure(EntityTypeBuilder<PurchaseModel> builder)
        {
        }
    }
}
