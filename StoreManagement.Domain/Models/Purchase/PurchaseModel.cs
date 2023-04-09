using StoreManagement.Domain.Models.BusinessEntity;
using StoreManagement.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Domain.Models.Purchase
{
    public class PurchaseModel
    {
        public Guid PurchaseId { get; set; }

        public Guid UserId { get; set; }

        public UserModel User { get; set; }

        public Guid BusinessEntiyId { get; set; }

        public BusinessEntityModel BusinessEntity { get; set; }

        public DateTime DateTime { get; set; }

        public float TotalAmount { get; set; }
    }
}
