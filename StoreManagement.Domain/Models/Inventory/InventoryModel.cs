﻿using Microsoft.EntityFrameworkCore;
using StoreManagement.Domain.Constants;
using StoreManagement.Domain.Models.BusinessEntity;
using StoreManagement.Domain.Models.Product;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Domain.Models.Inventory
{
    public class InventoryModel : BaseModel
    {
        [Key]
        public Guid InventoryId { get; set; }
        [Required]
        [MaxLength(ApplicationConstants.NameLength)]
        public string Name { get; set; }
        public Guid ProductId { get; set; }
        public ProductModel Product { get; set; }
        public int Stock { get; set; }

        [Precision(10,4)]
        public decimal UnitCost { get; set; }
        public Guid BusinessEntityId { get; set; }
        public BusinessEntityModel BusinessEntity { get; set; }
    }
}
