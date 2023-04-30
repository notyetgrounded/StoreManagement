using StoreManagement.Domain.Models.Product;
using StoreManagement.Repository.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Repository.Repositories.Product
{
    public class ProductsReposiory : IProductsReposiory
    {
        private StoreDbContext _storeDbContext;
        public ProductsReposiory(StoreDbContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }

        public void CreateProduct(ProductModel productModel)
        {
            _storeDbContext.Products.Add(productModel);
        }
    }
}
