using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeesSolution.Controllers;
using System.Web.Mvc;
using EmployeesSolution.Models;
using System.Collections.Generic;
using System.Linq;
using EmployeesSolution.DAL;
using EmployeesSolution.Logging;

namespace EmployeesSolutionTests
{
    [TestClass]
    public class EmployeesControllerTest
    {
        private readonly IEmployeeRepository _mockRepo;
        private readonly ILogger _logger;
        public EmployeesControllerTest()
        {
            _mockRepo = new EmployeeRepository();
            _logger = new Logger();
        }
        [TestMethod]
        public void TestViewName()
        {
            
            var controller = new EmployeesController(_mockRepo,_logger);
            var result = controller.List() as ViewResult;
            Assert.AreEqual("List", result.ViewName);
        }
        [TestMethod]
        public void TestModelCount()
        {
            var controller = new EmployeesController(_mockRepo, _logger);
            var result = controller.List() as ViewResult;
            var employee = (List<Employee>)result.ViewData.Model;
            Assert.AreEqual(4, employee.Count);
        }
        [TestMethod]
        public void TestSalaryGreaterThan60000()
        {
            var controller = new EmployeesController(_mockRepo, _logger);
            var result = controller.List() as ViewResult;
            var employee = (List<Employee>)result.ViewData.Model;
            var c = employee.Where(e => e.Salary > 60000).Count();
            Assert.AreEqual(2, c);
        }
        [TestMethod]
        public void TestUniqueDepartments()
        {
            var controller = new EmployeesController(_mockRepo, _logger);
            var result = controller.List() as ViewResult;
            var employee = (List<Employee>)result.ViewData.Model;
            var c = employee.Select(e => e.Department).Distinct().Count();
            Assert.AreEqual(3, c);
        }
    }
}
