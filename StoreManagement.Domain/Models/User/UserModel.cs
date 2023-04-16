using StoreManagement.Domain.Models.Employee;
using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Domain.Models.User
{
    public class UserModel
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        public string Code { get; set; }
        public string Name { get; set; }
        public IList<EmployeeModel> Employees { get; set; }
    }
}
