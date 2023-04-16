using StoreManagement.Domain.Models.User;

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
