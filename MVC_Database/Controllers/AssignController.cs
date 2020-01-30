using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Database.Controllers
{
    public class AssignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AssignStudent()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AssignTeacher()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AssignCourse()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AssignAssignment()
        {
            return View();
        }
    }
}