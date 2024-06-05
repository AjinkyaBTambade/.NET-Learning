using Microsoft.AspNetCore.Mvc;
using MVCWebAppDB.Models;
using MVCWebAppDB.Repositories;
namespace MVCWebAppDB.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserRepository _userRepository;

        public AccountController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            Console.WriteLine(user.Email + " " + user.Password);
            if (user.Email == "aj@gmail.com" && user.Password == "ajinkya")
            {
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Invalid credentials";
                return View();
            }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string username, string password, string email)
        {
            if (_userRepository.GetUserByUsername(username) == null)
            {
                var user = new User { Username = username, Password = password, Email = email };
                _userRepository.AddUser(user);
                return RedirectToAction("Login");
            }

            ViewBag.Message = "User already exists";
            return View();
        }
    }

}
