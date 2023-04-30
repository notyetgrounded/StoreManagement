using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreManagement.Domain.Models.Employee;
using StoreManagement.Domain.Models.Product;

namespace StoreManagement.Repository.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<EmployeeModel>
    {
        public void Configure(EntityTypeBuilder<EmployeeModel> builder)
        {
        }
    }
}
