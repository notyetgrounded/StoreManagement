using StoreManagement.Domain.Models.Product;

namespace StoreManagement.Repository.Repositories.Product
{
    public interface IProductsReposiory
    {
        void CreateProduct(ProductModel productModel);
    }
}