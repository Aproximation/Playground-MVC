using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MVC_Playground.Logic.Validations;

namespace MVC_Playground.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [FirstNameValidation]
        public string FirstName { get; set; }
        [StringLength(5, ErrorMessage = "Last Name length should not be greater than 5")]
        public string LastName { get; set; }
        [Range(5000, 50000, ErrorMessage ="Value must be >5000 and <50000")]
        public int Salary { get; set; }
    }
}
