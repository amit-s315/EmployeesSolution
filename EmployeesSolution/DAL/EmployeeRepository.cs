using EmployeesSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeesSolution.DAL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employees;
        public EmployeeRepository()
        {
            _employees = new List<Employee>();
            _employees.Add(new Employee
            {
                EmployeeId = 12345,
                EmployeeName = "Derek",
                Department = "IT",
                Salary = 55000.34
            });
            _employees.Add(new Employee
            {
                EmployeeId = 383848,
                EmployeeName = "Mark",
                Department = "HR",
                Salary = 61000
            });
            _employees.Add(new Employee
            {
                EmployeeId = 2828383,
                EmployeeName = "Lisa",
                Department = "IT",
                Salary = 59999.99
            });
            _employees.Add(new Employee
            {
                EmployeeId = 607075,
                EmployeeName = "James",
                Department = "Operations",
                Salary = 80000
            });
        }
        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }
    }
}