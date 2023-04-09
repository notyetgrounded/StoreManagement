using StoreManagement.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Domain.Models
{
    public class BaseModel
    {
        public Guid LastModifiedById { get; set; }

        public UserModel LastModifiedBy { get; set; }
        
        public DateTime LastModifiedDate { get; set;}

        public string LastModifiedReason { get; set;}
    }
}
