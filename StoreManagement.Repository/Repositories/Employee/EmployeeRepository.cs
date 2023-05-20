using StoreManagement.Repository.DatabaseContext;

namespace StoreManagement.Repository.Repositories.Employee
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private StoreDbContext _storeDbcontext;
        public EmployeeRepository(StoreDbContext storeDbContext)
        {
            _storeDbcontext = storeDbContext;
        }
    }
}
