using Microsoft.AspNetCore.Mvc;
using StateManagementApp.Models; // Ensure this is pointing to the correct namespace
using StateManagmentApp.Models;
using System.Text.Json;

namespace StateManagementApp.Controllers
{
    // Server Side State Management
    // Session Management
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            Cart theCart = new Cart();
            theCart.Items.Add("laptop");
            string json = JsonSerializer.Serialize(theCart);
            TempData["mycart"] = json;
            return RedirectToAction("RemoveFromCart");
        }

        // session is essential when data is supposed to be accessed
        // across any action method belonging to any controller
        public IActionResult RemoveFromCart()
        {
            if (TempData["mycart"] is string json)
            {
                Cart existingCart = JsonSerializer.Deserialize<Cart>(json);
                existingCart.Items.Remove("laptop");
                ViewData["mycart"] = existingCart;
            }
            return View();
        }
    }
}
