using Microsoft.EntityFrameworkCore;
using StoreManagement.Domain.Models.BusinessEntity;
using StoreManagement.Domain.Models.User;
using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Domain.Models.Purchase
{
    public class PurchaseModel
    {
        [Key]
        public Guid PurchaseId { get; set; }
        public Guid UserId { get; set; }
        public UserModel User { get; set; }
        public Guid BusinessEntiyId { get; set; }
        public BusinessEntityModel BusinessEntity { get; set; }
        public DateTime DateTime { get; set; }
        [Precision(10, 4)]
        public decimal TotalAmount { get; set; }
    }
}
