using StoreManagement.Domain.Models.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Domain.Models
{
    public class BaseModel
    {
        public string ModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set;}
        public string LastModifiedReason { get; set;}
    }
}
