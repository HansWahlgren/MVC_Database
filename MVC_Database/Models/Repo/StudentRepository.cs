using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_Database.Models
{
    public class StudentRepository : IStudentRepository
    {
        readonly SchoolDbContext _schoolDbContext;

        public StudentRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public List<Student> All()
        {
            return _schoolDbContext.Students.ToList();
        }

        public Student Create(Student student)
        {
            _schoolDbContext.Students.Add(student);
            _schoolDbContext.SaveChanges();

            return student;
        }

        public Student Find(int id)
        {
            return _schoolDbContext.Students
                .Include(student => student.PersonCourses).ThenInclude(student => student.Course)
                .SingleOrDefault(student => student.Id == id);
        }

        public Student Assign(PersonCourse personCourse)
        {
            Student student = Find(personCourse.StudentId);
            Course course = _schoolDbContext.Courses.SingleOrDefault(c => c.Id == personCourse.CourseId);

            _schoolDbContext.PersonCourses.Add(personCourse);
            _schoolDbContext.SaveChanges();

            return personCourse.Student;
        }
    }
}
