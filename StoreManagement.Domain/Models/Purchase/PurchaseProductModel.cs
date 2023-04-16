using StoreManagement.Domain.Models.Product;
using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Domain.Models.Purchase
{
    public class PurchaseProductModel
    {
        [Key]
        public Guid PurchaseProductId { get; set; }
        public Guid PurchaseId { get; set; }
        public PurchaseModel Purchase { get; set; }
        public Guid ProductId { get; set; }
        public ProductModel Product { get; set; }
        public float Quantity { get; set; }
        public float Amount { get; set; }
    }
}
