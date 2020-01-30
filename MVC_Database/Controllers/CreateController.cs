using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Database.Models;

namespace MVC_Database.Controllers
{
    public class CreateController : Controller
    {
        readonly IStudentService _studentService;
        readonly ITeacherService _teacherService;
        readonly ICourseService _courseService;
        readonly IAssignmentService _assignmentService;

        public CreateController(IStudentService studentService, ITeacherService teacherService, ICourseService courseService, IAssignmentService assignmentService)
        {
            _studentService = studentService;
            _teacherService = teacherService;
            _courseService = courseService;
            _assignmentService = assignmentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(StudentViewModel studentViewModel)
        {
            if (ModelState.IsValid)
            {
                _studentService.Create(studentViewModel);
                return RedirectToAction("Index");
            }

            return View(studentViewModel);
        }


        [HttpGet]
        public IActionResult CreateTeacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTeacher(TeacherViewModel teacherViewModel)
        {
            if (ModelState.IsValid)
            {
                _teacherService.Create(teacherViewModel);
                return RedirectToAction("Index");
            }

            return View(teacherViewModel);
        }


        [HttpGet]
        public IActionResult CreateCourse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCourse(CourseViewModel courseViewModel)
        {
            if (ModelState.IsValid)
            {
                _courseService.Create(courseViewModel);
                return RedirectToAction("Index");
            }

            return View(courseViewModel);
        }


        [HttpGet]
        public IActionResult CreateAssignment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAssignment(AssignmentViewModel assignmentViewModel)
        {
            if (ModelState.IsValid)
            {
                _assignmentService.Create(assignmentViewModel);
                return RedirectToAction("Index");
            }

            return View(assignmentViewModel);
        }
    }
}