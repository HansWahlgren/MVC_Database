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
        }


        [HttpGet]
        public IActionResult AssignStudent()
        {
            List<Student> students = _studentService.All();
            List<Course> courses = _courseService.All();
            var model = new AssignViewModel { StudentList = students, CourseList = courses };

            return View(model);
        }

        [HttpPost]
        public IActionResult AssignStudent(int stuId, int couId)
        {
            if (stuId != 0 && couId != 0)
            {
                _studentService.Assign(stuId, couId);
            }
            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult AssignTeacher()
        {
            List<Teacher> teachers = _teacherService.All();
            List<Course> courses = _courseService.All();
            var model = new AssignViewModel { TeacherList = teachers, CourseList = courses };

            return View(model);
        }

        [HttpPost]
        public IActionResult AssignTeacher(int teaId, int couId)
        {
            if (teaId != 0 && couId != 0)
            {
                _teacherService.Assign(teaId, couId);
            }
            return RedirectToAction("Index");

        }



        [HttpGet]
        public IActionResult AssignAssignment()
        {
            List<Assignment> assignments = _assignmentService.All();
            List<Course> courses = _courseService.All();
            var model = new AssignViewModel { AssignmentList = assignments, CourseList = courses };

            return View(model);
        }

        [HttpPost]
        public IActionResult AssignAssignment(int assId, int couId)
        {
            if (assId != 0 && couId != 0)
            {
                _assignmentService.Assign(assId, couId);
            }
            return RedirectToAction("Index");
        }


        //[HttpGet]
        //public IActionResult CoursePartial()
        //{
        //    return PartialView("_SelectCourse", _courseService.All());
        //}
    }
}