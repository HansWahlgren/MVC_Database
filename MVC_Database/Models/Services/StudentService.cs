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
            throw new NotImplementedException();
        }

        public Student Create(StudentViewModel student)
        {
            throw new NotImplementedException();
        }

        public Student Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
