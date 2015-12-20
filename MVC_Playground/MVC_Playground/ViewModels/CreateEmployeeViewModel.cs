using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Playground.Models;

namespace MVC_Playground.ViewModels
{
    public class CreateEmployeeViewModel: BaseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public CreateEmployeeViewModel() {}
        public CreateEmployeeViewModel(Employee e) {
            FirstName = e.FirstName;
            LastName = e.LastName;
            Salary = e.Salary;
        }
    }
}