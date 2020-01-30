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
            return View(_courseService.All());
        }

        [HttpGet]
        public IActionResult AssignToCourse(int id)
        {
            return View(id);
        }


        [HttpGet]
        public IActionResult AssignStudent(int id)
        {
            return View(_studentService.All());
        }

        [HttpGet]
        public IActionResult SelectStudent(int id)
        {
            //_studentService.Assign(id, courseId);

            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult AssignTeacher()
        {
            return View(_teacherService.All());
        }

        [HttpGet]
        public IActionResult SelectTeacher(int id)
        {
            //_teacherService.Assign(id, courseId);

            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult AssignAssignment()
        {
            return View(_assignmentService.All());
        }

        [HttpGet]
        public IActionResult SelectAssignment(int id)
        {
            //_assignmentService.Assign(id, courseId);

            return RedirectToAction("Index");
        }
    }
}