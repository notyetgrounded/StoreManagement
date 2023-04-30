using StoreManagement.Repository.Repositories.Permissions;
using StoreManagement.Repository.Repositories.Product;
using StoreManagement.Repository.Repositories.Purchase;
using StoreManagement.Repository.Repositories.UnitOfWork;
using StoreManagement.Repository.Repositories.User;

namespace StoreManagement.Repository.Repositories.RepositoryManager
{
    public interface IRepositoryManager
    {
        IPermissionsRepository PermissionsRepository { get; }
        IProductsReposiory ProductsReposiory { get; }
        IPurchaseRepository PurchaseRepository { get; }
        IUnitOfWorkRepository UnitOfWorkRepository { get; }
        IUserRepository UsersRepository { get; }
    }
}