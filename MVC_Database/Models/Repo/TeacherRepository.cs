using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_Database.Models
{
    public class TeacherRepository : ITeacherRepository
    {
        readonly SchoolDbContext _schoolDbContext;

        public TeacherRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public List<Teacher> All()
        {
            return _schoolDbContext.Teachers.ToList();
        }

        public Teacher Create(Teacher teacher)
        {
            _schoolDbContext.Teachers.Add(teacher);
            _schoolDbContext.SaveChanges();

            return teacher;
        }

        public Teacher Find(int id)
        {
            return _schoolDbContext.Teachers.SingleOrDefault(teacher => teacher.Id == id);
        }

        public Teacher Assign(int teaId, int couId)
        {
            Course course = _schoolDbContext.Courses.SingleOrDefault(c => c.Id == couId);
            var teacher = Find(teaId);
            course.Teacher = teacher;
            _schoolDbContext.SaveChanges();

            return Find(teaId);
        }
    }
}
