using StoreManagement.Repository.DatabaseContext;

namespace StoreManagement.Repository.Repositories.BusinessEntity
{
    public class BusinessEntityRepository : IBusinessEntityRepository
    {
        private StoreDbContext _storeDbcontext;
        public BusinessEntityRepository(StoreDbContext storeDbContext)
        {
            _storeDbcontext = storeDbContext;
        }
    }
}
