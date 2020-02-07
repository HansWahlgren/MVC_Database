using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public class CreateViewModel
    {
        public AssignmentViewModel Assignment { get; set; }

        public CourseViewModel Course { get; set; }

        public List<Course> CourseList { get; set; }

        public List<Teacher> TeacherList { get; set; }

    }
}
