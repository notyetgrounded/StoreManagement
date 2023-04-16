using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Domain.Models.Permissions
{
    public class PermissionModel
    {
        [Key]
        public Guid PermissionId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
