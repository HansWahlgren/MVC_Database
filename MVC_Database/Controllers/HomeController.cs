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
        public HomeController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            return View(_courseService.All());
        }

        public IActionResult ViewCourse(int id)
        {
            return View(_courseService.Find(id));
        }
    }
}