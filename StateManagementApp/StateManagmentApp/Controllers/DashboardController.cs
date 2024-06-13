using Microsoft.AspNetCore.Mvc;
using StateManagmentApp.Models;
using System.Collections.Generic;

namespace MyApplication.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var companies = new List<Company>
            {
                new Company { CompanyId = 1, Name = "Tech Innovators", Industry = "Technology", NumberOfEmployees = 1500, Location = "San Francisco" },
                new Company { CompanyId = 2, Name = "Health Solutions", Industry = "Healthcare", NumberOfEmployees = 500, Location = "New York" },
                new Company { CompanyId = 3, Name = "Green Energy", Industry = "Energy", NumberOfEmployees = 2000, Location = "Austin" }
                // Add more companies as needed
            };

            return View("Dashboard", companies);
        }
    }
}
