using StoreManagement.Domain.Models.BusinessEntity;
using StoreManagement.Domain.Models.User;
using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Domain.Models.Permissions
{
    public class SecurityRoleAssociationModel : BaseModel
    {
        [Key]
        public Guid SecurityRoleAssociationId { get; set; }
        public Guid UserId { get; set; }
        public UserModel User { get; set; }
        public Guid PermissionId { get; set; }
        public PermissionModel Permission { get; set; }
        public Guid BusinessEntityId { get; set; }
        public BusinessEntityModel BusinessEntity { get; set; }
        public int Level { get; set; }
    }
}
