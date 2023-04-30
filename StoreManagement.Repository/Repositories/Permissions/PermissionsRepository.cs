using StoreManagement.Domain.Models.Permissions;
using StoreManagement.Repository.DatabaseContext;

namespace StoreManagement.Repository.Repositories.Permissions
{
    public class PermissionsRepository : IPermissionsRepository
    {
        private StoreDbContext _storeDbcontext;
        public PermissionsRepository(StoreDbContext storeDbContext)
        {
            _storeDbcontext = storeDbContext;
        }

        public void CreatePermission(PermissionModel permissionModel)
        {
            _storeDbcontext.Permissions.Add(permissionModel);
        }
    }
}
