using EmployeesSolution.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeesSolution.Logging;

namespace EmployeesSolution.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _repo;
        private readonly ILogger _logger;

        public EmployeesController(IEmployeeRepository repo, ILogger logger)
        {
            _repo = repo;
            _logger = logger;
        }
        // GET: Employees
        public ActionResult List()
        {
            IEnumerable<EmployeesSolution.Models.Employee> employees;
            try
            {
                employees = _repo.GetAll();
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
            }

            return View("List", _repo.GetAll());
        }
    }
}