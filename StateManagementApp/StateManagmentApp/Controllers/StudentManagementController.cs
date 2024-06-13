using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using StateManagmentApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagmentApp.Controllers
{
    public class StudentManagementController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Bar()
        {
            var markList = GetStudentMarkList();
            return View(markList);
        }
        public IActionResult Line()
        {
            var markList = GetStudentMarkList();
            return View(markList);
        }
     
        //Make function in models and get data from database as per your requirement... //Dont do in controller like this
        public List<StudentMarkDetails> GetStudentMarkList()
        {
            var studentmarkList = new List<StudentMarkDetails>()
            {
                new StudentMarkDetails() { id = 1, name = "Ajinkya", Physics = 62,Chemistry=78,Biology=84,Mathematics=96 },
                new StudentMarkDetails() { id = 2, name = "Nayan", Physics = 96,Chemistry=78,Biology=69,Mathematics=88 },
                new StudentMarkDetails() { id = 3, name = "Bhupendra", Physics = 49,Chemistry=85,Biology=63,Mathematics=77 },
                new StudentMarkDetails() { id = 4, name = "Shridhar", Physics = 85,Chemistry=56,Biology=78,Mathematics=55 },
                new StudentMarkDetails() { id = 5, name = "Ritesh", Physics = 74,Chemistry=55,Biology=36,Mathematics=69 },
            };
            return studentmarkList;
        }
        public List<StudentScoreDetails> GetStudentScoreDetails()
        {
            var studentscoreList = new List<StudentScoreDetails>()
            {
                new StudentScoreDetails() { id = 1, name = "Ajinkya", score = 62},
                new StudentScoreDetails() { id = 2, name = "Nayan", score = 96 },
                new StudentScoreDetails() { id = 3, name = "Bhupendra", score = 49 },
                new StudentScoreDetails() { id = 4, name = "Shridhar", score = 85 },
                new StudentScoreDetails() { id = 5, name = "Ritesh", score = 74},
            };
            return studentscoreList;
        }

    }
}