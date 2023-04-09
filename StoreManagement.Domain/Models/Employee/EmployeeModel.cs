using StoreManagement.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Domain.Models.Employee
{
    public class EmployeeModel
    {
        [Required]
        public Guid EmployeeId { get; set; }

        [Required]
        public Guid UserId { get; set; }
        
        public UserModel User { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
