using StoreManagement.Domain.Constants;
using StoreManagement.Domain.Models.Inventory;
using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Domain.Models.Product
{
    public class ProductModel : BaseModel
    {
        [Key]
        public Guid ProductId { get; set; }
        [Required]
        [MaxLength(ApplicationConstants.CodeLength)]
        public string Code { get; set; }
        [Required]
        [MaxLength(ApplicationConstants.NameLength)]
        public string Name { get; set; }
        [MaxLength(ApplicationConstants.DescriptionLength)]
        public string Description { get; set; }
        public IList<InventoryModel> Inventories { get; set; }
    }
}
