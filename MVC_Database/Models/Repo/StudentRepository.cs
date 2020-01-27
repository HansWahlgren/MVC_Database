using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public Student Create(Student student)
        {
            throw new NotImplementedException();
        }

        public Student Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
