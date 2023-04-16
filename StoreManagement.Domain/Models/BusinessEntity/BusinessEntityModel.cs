﻿using StoreManagement.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Domain.Models.BusinessEntity
{
    public class BusinessEntityModel : BaseModel
    {
        [Key]
        public Guid BusinessEntityId { get; set; }

        [MaxLength(ApplicationConstants.NameLength)]
        public string Name { get; set;}

        [MaxLength(ApplicationConstants.DescriptionLength)]
        public string Description { get; set;}
        public int Type { get; set;}
    }
}
