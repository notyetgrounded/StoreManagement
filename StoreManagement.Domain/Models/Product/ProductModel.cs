using StoreManagement.Domain.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Domain.Models.Product
{
    public class ProductModel : BaseModel
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IList<InventoryModel> Inventories { get; set; }
    }
}
