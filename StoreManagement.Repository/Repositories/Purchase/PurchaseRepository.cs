using StoreManagement.Domain.Models.Purchase;
using StoreManagement.Repository.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Repository.Repositories.Purchase
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private StoreDbContext _storeDbContext { get; set; }

        public PurchaseRepository(StoreDbContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }

        public void CreatePurshase(PurchaseModel purchaseModel)
        {
            _storeDbContext.Purchases.Add(purchaseModel);
        }
    }
}
