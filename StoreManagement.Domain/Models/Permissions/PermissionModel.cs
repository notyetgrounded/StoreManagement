using StoreManagement.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Domain.Models.Permissions
{
    public class PermissionModel
    {
        [Key]
        public Guid PermissionId { get; set; }

        [Required]
        [MaxLength(ApplicationConstants.CodeLength)]
        public string Code { get; set; }
        [MaxLength(ApplicationConstants.DescriptionLength)]
        public string Description { get; set; }
    }
}
