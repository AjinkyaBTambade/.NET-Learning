using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Entities;
using MVCWebApp.Repositories;

namespace MVCWebApp.Controllers
{
    public class CustomerController : Controller
    {
        // http://localhost:9999/customers
        public IActionResult Index()
        {
            CustomerRepository repository = new CustomerRepository();
            List<Customer> customers = repository.GetAll();
            ViewData["allCustomers"] = customers;
            return View();
        }


        // http://localhost:9999/customers/details/45
        public IActionResult Details(int id)
        {

            CustomerRepository repository = new CustomerRepository();
            List<Customer> customers = repository.GetAll();
            Customer theCustomer = customers.Find(x => x.Id == id);
            ViewData["id"] = theCustomer.Id;
            ViewData["name"] = theCustomer.Name;
            ViewData["email"] = theCustomer.Email;
            ViewData["phone"] = theCustomer.Phone;
            return View();
        }


        // http://localhost:9999/customers/remove/45
        public IActionResult Remove(int id)
        {
            //Code for removal customer from list
            CustomerRepository repository = new CustomerRepository();
            List<Customer> customers = repository.GetAll();
            Customer theCustomer = customers.Find(x => x.Id == id);
            customers.Remove(theCustomer);
            return RedirectToAction("Index");
            //return View();
            //return Json();

        }
    }

}
