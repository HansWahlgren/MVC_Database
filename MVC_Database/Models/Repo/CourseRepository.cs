using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public class CourseRepository : ICourseRepository
    {
        readonly SchoolDbContext _schoolDbContext;

        public CourseRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public List<Course> All()
        {
            return _schoolDbContext.Courses.ToList();
        }

        public Course Create(Course course)
        {
            _schoolDbContext.Courses.Add(course);
            _schoolDbContext.SaveChanges();

            return course;
        }

        public Course Find(int id)
        {
            return _schoolDbContext.Courses
                .Include(cource => cource.Teacher)
                .Include(course => course.Assignments)
                .Include(course => course.PersonCourses).ThenInclude(course => course.Student)
                .SingleOrDefault(course => course.Id == id);
        }
    }
}
