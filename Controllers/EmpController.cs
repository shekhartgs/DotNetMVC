using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBusiness;

namespace MVC.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            EmployeeBusiness employeeBusiness = new EmployeeBusiness();
            List<Employee> employees = employeeBusiness.Employees.ToList();
            return View(employees);
        }
    }
}