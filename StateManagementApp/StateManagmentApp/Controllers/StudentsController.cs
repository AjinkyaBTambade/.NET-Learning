using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

namespace StateManagmentApp.Controllers
{
    public class StudentsController : Controller
    {
        [OutputCache]
        public IActionResult Index()
        {
            List<string> students = new List<string>();
            students.Add("Ajinkya");
            students.Add("Shridhar");
            students.Add("Bhupendra");
            students.Add("Ritesh");
            return Json(students);
        }
    }
}
