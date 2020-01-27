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
            throw new NotImplementedException();
        }

        public Course Create(Course course)
        {
            throw new NotImplementedException();
        }

        public Course Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
