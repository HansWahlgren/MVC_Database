using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Database.Models;

namespace MVC_Database.Controllers
{
    public class AssignController : Controller
    {
        readonly IStudentService _studentService;
        readonly ITeacherService _teacherService;
        readonly ICourseService _courseService;
        readonly IAssignmentService _assignmentService;

        public AssignController(IStudentService studentService, ITeacherService teacherService, ICourseService courseService, IAssignmentService assignmentService)
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
            //return View(_courseService.All());
        }


        [HttpGet]
        public IActionResult AssignStudent()
        {
            return View(_studentService.All());
        }

        [HttpPost]
        public IActionResult AssignStudent(int stuId, int couId)
        {
            //_studentService.Assign(id, courseId);

            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult AssignTeacher()
        {
            return View(_teacherService.All());
        }

        [HttpPost]
        public IActionResult SelectTeacher()
        {
            //_teacherService.Assign(id, courseId);

            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult AssignAssignment()
        {
            return View(_assignmentService.All());
        }

        [HttpPost]
        public IActionResult SelectAssignment()
        {
            //_assignmentService.Assign(id, courseId);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult CreateCoursePartial()
        {
            return PartialView("_SelectCourse", _courseService.All());
        }
    }
}