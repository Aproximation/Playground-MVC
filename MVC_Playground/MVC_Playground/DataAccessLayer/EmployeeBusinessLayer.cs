using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Playground.Models;

namespace MVC_Playground.DataAccessLayer
{
    class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            UsersDAL salesDal = new UsersDAL();
            return salesDal.Employees.ToList();
        }

        public Employee SaveEmployee(Employee e)
        {
            UsersDAL salesDal = new UsersDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }

        public bool IsValidUser(UserDetails u)
        {
            if (u.UserName == "Admin" && u.Password == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Employee> GetEmployeesOld()
        {
            List < Employee > employees = new List<Employee> ();
            Employee emp = new Employee();
            emp.FirstName = "johnson";
            emp.LastName = " fernandes";
            emp.Salary = 14000;
            employees.Add(emp);

            Employee emp2 = new Employee();
            emp2.FirstName = "johnson";
            emp2.LastName = " fernandes";
            emp2.Salary = 16000;
            employees.Add(emp2);

            return employees;
        }
    }
}
