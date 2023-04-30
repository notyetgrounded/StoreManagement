using StoreManagement.Domain.Models.Permissions;

namespace StoreManagement.Repository.Repositories.Permissions
{
    public interface IPermissionsRepository
    {
        void CreatePermission(PermissionModel permissionModel);
    }
}