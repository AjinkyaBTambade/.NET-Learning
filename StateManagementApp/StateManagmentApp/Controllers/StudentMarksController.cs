using Microsoft.AspNetCore.Mvc;
using StateManagmentApp.Models;

namespace StateManagmentApp.Controllers
{
    public class StudentMarksController : Controller
    {
        public IActionResult Index()
        {
            // Hardcoded student marks
            var studentMarks = new List<StudentMark>
            {
                new StudentMark { Name = "Ajinkya", Marks = 95 },
                new StudentMark { Name = "Bhupendra", Marks = 80 },
                new StudentMark { Name = "Ritesh", Marks = 78 },
                new StudentMark { Name = "Shridhar", Marks = 68 },
                new StudentMark { Name = "Nayan", Marks = 42 }
            };

            return View(studentMarks);
        }
    }
}
