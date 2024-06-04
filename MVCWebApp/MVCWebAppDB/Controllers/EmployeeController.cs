using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCWebAppDB.Data;
using MVCWebAppDB.Models;
using MVCWebAppDB.Repositories;

namespace MVCWebAppDB.Controllers
{
    public class EmployeeController : Controller
    {
            public IActionResult Index()
            {
                using (MVCWebAppDBContext _context = new MVCWebAppDBContext())
                {
                    EmployeeRepository repo = new EmployeeRepository(_context);
                    List<Employee> employees = repo.GetAll();
                    ViewData["allEmployees"] = employees;
                }
                return View();
            }
            public IActionResult Details(int id)
            {
                using (MVCWebAppDBContext _context = new MVCWebAppDBContext())
                {
                    EmployeeRepository repo = new EmployeeRepository(_context);
                    List<Employee> employees = repo.GetAll();
                    Employee emp = employees.Find(x => x.Id == id);

                    ViewData["SingleEmployee"] = emp;
                }
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
                Console.WriteLine(employee.Name);
                using (MVCWebAppDBContext _context = new MVCWebAppDBContext())
                {
                    EmployeeRepository repo = new EmployeeRepository(_context);
                    bool status = repo.Insert(employee);

                    Console.WriteLine(status);
                }
                return RedirectToAction("Index");
            }

            [HttpGet]
            public IActionResult Update(int id)
            {
                using (MVCWebAppDBContext _context = new MVCWebAppDBContext())
                {
                    EmployeeRepository repo = new EmployeeRepository(_context);


                    Employee employee = repo.Details(id);
                    return View(employee);


                }
                //return View(employee);
            }
            [HttpPost]
            public IActionResult Update(Employee employee)
            {
                Console.WriteLine($"{employee.Name}");
                using (MVCWebAppDBContext _context = new MVCWebAppDBContext())
                {
                    EmployeeRepository repo = new EmployeeRepository(_context);
                    bool status = repo.Update(employee);

                    Console.WriteLine(status);
                }
                return RedirectToAction("Index");
            }
            public IActionResult Remove(int id)
            {
                using (MVCWebAppDBContext _context = new MVCWebAppDBContext())
                {
                    EmployeeRepository repo = new EmployeeRepository(_context);
                    bool status = repo.Remove(id);

                }
                return RedirectToAction("Index");
            }


        }
    }