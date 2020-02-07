using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Database.Models;

namespace MVC_Database.Controllers
{
    public class HomeController : Controller
    {
        readonly ICourseService _courseService;
        readonly IStudentService _studentService;
        public HomeController(ICourseService courseService, IStudentService studentService)
        {
            _courseService = courseService;
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_courseService.All());
        }

        [HttpGet]
        public IActionResult ViewCourse(int id)
        {
            return View(_courseService.Find(id));
        }


        [HttpGet]
        public IActionResult StudentList()
        {
            return View(_studentService.All());
        }

        [HttpGet]
        public IActionResult ViewStudent(int id)
        {
            return View(_studentService.Find(id));
        }
    }
}