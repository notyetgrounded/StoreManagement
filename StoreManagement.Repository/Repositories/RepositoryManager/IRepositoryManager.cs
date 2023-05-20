using StoreManagement.Repository.Repositories.BusinessEntity;
using StoreManagement.Repository.Repositories.Employee;
using StoreManagement.Repository.Repositories.Inventory;
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
        IInventoryRepository InventoriesRepository { get; }
        IEmployeeRepository EmployeesRepository { get; }
        IBusinessEntityRepository BusinessEntitiesRepository { get; }
    }
}