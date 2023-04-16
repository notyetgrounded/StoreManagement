using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Domain.Models.BusinessEntity
{
    public class LinkedBusinessEntitesModel : BaseModel
    {
        [Key]
        public Guid LinkedBusinessEntitesId { get; set; }
        public Guid ParentBusinessEntityId { get; set; }
        public BusinessEntityModel ParentBusinessEntity { get; set; }
        public Guid ChildBusinessEntityId { get; set; }
        public BusinessEntityModel ChildBusinessEntity { get; set; }
    }
}
