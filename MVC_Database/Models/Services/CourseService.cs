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
            return _courseRepository.All();
        }

        public Course Create(CourseViewModel course)
        {
            Course newCourse = new Course()
            {
                Title = course.Title,
                Description = course.Description,
                Teacher = course.Teacher
            };
            return _courseRepository.Create(newCourse);
        }

        public Course Find(int id)
        {
            return _courseRepository.Find(id);
        }
    }
}
