using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Mono.TextTemplating;

namespace StateManagementApp.Controllers
{
    public class StateMgmtController : Controller
    {
        private readonly ILogger<StateMgmtController> _logger;

        public StateMgmtController(ILogger<StateMgmtController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //State Management : Session 
        [HttpPost]
        public IActionResult SetSession(string userName)
        {
            HttpContext.Session.SetString("UserName", userName);
            return RedirectToAction("Index");
        }

        public IActionResult GetSession()
        {
            var userName = HttpContext.Session.GetString("UserName");
            ViewBag.UserName = userName ?? "Session data not found.";
            return View();
        }

        //State Management : Query String
        public IActionResult SetQueryString(string userName)
        {
            return RedirectToAction("GetQueryString", new { userName = userName });
        }

        public IActionResult GetQueryString(string userName)
        {
            ViewBag.UserName = userName ?? "Query string data not found.";
            return View();
        }


        //State Management : Cookies
        public IActionResult SetCookie(string userName)
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddMinutes(30);
            Response.Cookies.Append("UserName", userName, options);
            return RedirectToAction("Index");
        }

        public IActionResult GetCookie()
        {
            var userName = Request.Cookies["UserName"];
            ViewBag.UserName = userName ?? "Cookie data not found.";
            return View();
        }

    }

}
