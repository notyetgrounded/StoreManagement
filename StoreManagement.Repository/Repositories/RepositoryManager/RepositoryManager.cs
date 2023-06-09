﻿using StoreManagement.Repository.DatabaseContext;
using StoreManagement.Repository.Repositories.BusinessEntity;
using StoreManagement.Repository.Repositories.Employee;
using StoreManagement.Repository.Repositories.Inventory;
using StoreManagement.Repository.Repositories.Permissions;
using StoreManagement.Repository.Repositories.Product;
using StoreManagement.Repository.Repositories.Purchase;
using StoreManagement.Repository.Repositories.UnitOfWork;
using StoreManagement.Repository.Repositories.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Repository.Repositories.RepositoryManager
{
    public class RepositoryManager : IRepositoryManager
    {
        private Lazy<IPermissionsRepository> _lazyPermissionsRepository;
        private Lazy<IProductsReposiory> _lazyProductsReposotory;
        private Lazy<IUserRepository> _lazyUserRepository;
        private Lazy<IPurchaseRepository> _lazyPurchaseRepository;
        private Lazy<IUnitOfWorkRepository> _lazyUnitOfWorkRepository;
        private Lazy<IInventoryRepository> _lazyInventoriesRepository;
        private Lazy<IEmployeeRepository> _lazyEmployeesRepository;
        private Lazy<IBusinessEntityRepository> _lazyBusinessEntitiesRepository;

        public RepositoryManager(StoreDbContext storeDbcontext)
        {
            _lazyPermissionsRepository = new Lazy<IPermissionsRepository>(() => new PermissionsRepository(storeDbcontext));
            _lazyProductsReposotory = new Lazy<IProductsReposiory>(() => new ProductsReposiory(storeDbcontext));
            _lazyPurchaseRepository = new Lazy<IPurchaseRepository>(() => new PurchaseRepository(storeDbcontext));
            _lazyUserRepository = new Lazy<IUserRepository>(() => new UserRepository(storeDbcontext));
            _lazyUnitOfWorkRepository = new Lazy<IUnitOfWorkRepository>(() => new UnitOfWorkRepository(storeDbcontext));
            _lazyInventoriesRepository = new Lazy<IInventoryRepository>(() => new InventoryRepository(storeDbcontext));
            _lazyEmployeesRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(storeDbcontext));
            _lazyBusinessEntitiesRepository = new Lazy<IBusinessEntityRepository>(() => new BusinessEntityRepository(storeDbcontext));
        }

        public IPurchaseRepository PurchaseRepository => _lazyPurchaseRepository.Value;
        public IProductsReposiory ProductsReposiory => _lazyProductsReposotory.Value;
        public IUserRepository UsersRepository => _lazyUserRepository.Value;
        public IPermissionsRepository PermissionsRepository => _lazyPermissionsRepository.Value;
        public IUnitOfWorkRepository UnitOfWorkRepository => _lazyUnitOfWorkRepository.Value;
        public IInventoryRepository InventoriesRepository => _lazyInventoriesRepository.Value;
        public IEmployeeRepository EmployeesRepository => _lazyEmployeesRepository.Value;
        public IBusinessEntityRepository BusinessEntitiesRepository => _lazyBusinessEntitiesRepository.Value;
    }
}
