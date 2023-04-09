using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Domain.Models.Permissions
{
    public class PermissionModel
    {
        public Guid PermissionId { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }
    }
}
