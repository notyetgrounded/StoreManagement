using StoreManagement.Domain.Models.User;
using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Domain.Models.Employee
{
    public class EmployeeModel
    {
        [Key]
        public Guid EmployeeId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public UserModel User { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
