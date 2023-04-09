using StoreManagement.Domain.Models.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Domain.Models.User
{
    public class UserModel
    {
        public Guid UserId { get; set; }

        [Required]
        public string Code { get; set; }

        public string Name { get; set; }

        public IList<EmployeeModel> Employees { get; set; }

    }
}
