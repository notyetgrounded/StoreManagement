using StoreManagement.Domain.Models.BusinessEntity;
using StoreManagement.Domain.Models.Product;
using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Domain.Models.Inventory
{
    public class InventoryModel : BaseModel
    {
        [Key]
        public Guid InventoryId { get; set; }
        public string Name { get; set; }
        public Guid ProductId { get; set; }
        public ProductModel Product { get; set; }
        public int Stock { get; set; }
        public float UnitCost { get; set; }
        public Guid BusinessEntityId { get; set; }
        public BusinessEntityModel BusinessEntity { get; set; }
    }
}
