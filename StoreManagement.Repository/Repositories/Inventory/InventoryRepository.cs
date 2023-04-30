using StoreManagement.Repository.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Repository.Repositories.Inventory
{
    public class InventoryRepository : IInventoryRepository
    {
        private StoreDbContext _storeDbcontext;
        public InventoryRepository(StoreDbContext storeDbContext)
        {
            _storeDbcontext = storeDbContext;
        }
    }
}
