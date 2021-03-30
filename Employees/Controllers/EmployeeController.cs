using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Employees.Models;


namespace Employees.Controllers
{
    public class EmployeeController : Controller
    {
        private static Employee employee = new Employee();
        public ActionResult Search()
        {
            return View(employee.LINQQuery());
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            return View(employee.employeeList);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View(employee.getEmployee(id));
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                EmployeeProperties localEmpProps = new EmployeeProperties();

                localEmpProps.Id = int.Parse(collection["Id"]);
                localEmpProps.FirstName = collection["FirstName"];
                localEmpProps.LastName = collection["LastName"];
                localEmpProps.Location = collection["Location"];
                localEmpProps.Email = collection["Email"];
                localEmpProps.Salary = decimal.Parse(collection["Salary"]);

                employee.addNewEmployee(localEmpProps);

              
                return RedirectToAction("Index");

                
            }
            catch
            {
                return View();
            }

            
        }
    }
}
