using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public class TeacherService : ITeacherService
    {
        readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public List<Teacher> All()
        {
            throw new NotImplementedException();
        }

        public Teacher Create(TeacherViewModel teacher)
        {
            throw new NotImplementedException();
        }

        public Teacher Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
