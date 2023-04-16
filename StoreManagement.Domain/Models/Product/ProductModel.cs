using StoreManagement.Domain.Models.Inventory;
using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Domain.Models.Product
{
    public class ProductModel : BaseModel
    {
        [Key]
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<InventoryModel> Inventories { get; set; }
    }
}
