using StoreManagement.Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Domain.Models.BusinessEntity
{
    public class BusinessEntityModel : BaseModel
    {
        public Guid BusinessEntityId { get; set; }

        [MaxLength(ApplicationConstants.NameLength)]
        public string Name { get; set;}

        [MaxLength(ApplicationConstants.DescriptionLength)]
        public string Description { get; set;}

        public int Type { get; set;}
    }
}
