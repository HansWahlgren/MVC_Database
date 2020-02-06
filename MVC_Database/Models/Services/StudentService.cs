using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public class StudentService : IStudentService
    {
        readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> All()
        {
            return _studentRepository.All();
        }

        public Student Create(StudentViewModel student)
        {
            Student newStudent = new Student
            {
                Name = student.Name,
                Email = student.Email
            };
            return _studentRepository.Create(newStudent);
        }

        public Student Find(int id)
        {
            return _studentRepository.Find(id);
        }

        public Student Assign(int stuId, int couId)
        {
            Student student = Find(stuId);

            foreach (var course in student.PersonCourses)
            {
                if (course.Course.Id == couId)
                {
                    return student;
                }
            }

            //PersonCourse personCourse = new PersonCourse
            //{
            //    CourseId = couId,
            //    StudentId = stuId
            //};

            //return _studentRepository.Assign(personCourse);

            return _studentRepository.Assign(stuId, couId);
        }
    }
}
