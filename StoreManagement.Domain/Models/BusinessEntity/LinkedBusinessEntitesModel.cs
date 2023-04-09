using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Domain.Models.BusinessEntity
{
    public class LinkedBusinessEntitesModel : BaseModel
    {
        public Guid LinkedBusinessEntitesId { get; set; }

        public Guid ParentBusinessEntityId { get; set; }

        public BusinessEntityModel ParentBusinessEntity { get; set; }

        public Guid ChildBusinessEntityId { get; set; }

        public BusinessEntityModel ChildBusinessEntity { get; set; }
    }
}
