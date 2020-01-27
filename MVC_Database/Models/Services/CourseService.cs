using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public class CourseService : ICourseService
    {
        readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public List<Course> All()
        {
            throw new NotImplementedException();
        }

        public Course Create(CourseViewModel course)
        {
            throw new NotImplementedException();
        }

        public Course Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
