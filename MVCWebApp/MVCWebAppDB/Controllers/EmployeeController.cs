using Microsoft.AspNetCore.Mvc;
using MVCWebAppDB.Data;
using MVCWebAppDB.Models;
using MVCWebAppDB.Repositories;
using System.Collections.Generic;

namespace MVCWebAppDB.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeRepository _repo;

        public EmployeeController(MVCWebAppDBContext context)
        {
            _repo = new EmployeeRepository(context);
        }

        public IActionResult Index()
        {
            List<Employee> employees = _repo.GetAll();
            ViewData["allEmployees"] = employees;
            return View();
        }

        public IActionResult Details(int id)
        {
            Employee emp = _repo.Details(id);
            ViewData["SingleEmployee"] = emp;
            return View();
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Employee employee)
        {
            if (ModelState.IsValid)
            {
                bool status = _repo.Insert(employee);
                if (status)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Employee employee = _repo.Details(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                bool status = _repo.Update(employee);
                if (status)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(employee);
        }

        public IActionResult Remove(int id)
        {
            bool status = _repo.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
