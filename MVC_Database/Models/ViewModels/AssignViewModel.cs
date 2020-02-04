using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public class AssignViewModel
    {
        public List<Student> StudentList { get; set; }

        public List<Course> CourseList { get; set; }

        public List<Teacher> TeacherList { get; set; }

        public List<Assignment> AssignmentList { get; set; }
    }
}
