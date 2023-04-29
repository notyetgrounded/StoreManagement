using StoreManagement.Domain.Constants;
using StoreManagement.Domain.Models.Employee;
using StoreManagement.Domain.Models.Permissions;
using StoreManagement.Domain.Models.Purchase;
using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Domain.Models.User
{
    public class UserModel
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        [MaxLength(ApplicationConstants.CodeLength)]
        public string Code { get; set; }
        [Required]
        [MaxLength(ApplicationConstants.NameLength)]
        public string Name { get; set; }
        public IList<SecurityRoleAssociationModel> SecurityRoleAssociations { get; set; }
        public IList<EmployeeModel> Employees { get; set; }
        public IList<PurchaseModel> Purchases { get; set; }
    }
}
