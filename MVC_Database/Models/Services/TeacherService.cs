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
            return _teacherRepository.All();
        }

        public Teacher Create(TeacherViewModel teacher)
        {
            Teacher newTeacher = new Teacher
            {
                Name = teacher.Name,
                Email = teacher.Email,
                Office = teacher.Office
            };
            return _teacherRepository.Create(newTeacher);
        }

        public Teacher Find(int id)
        {
            return _teacherRepository.Find(id);
        }

        public Teacher Assign(int teaId, int couId)
        {
            return _teacherRepository.Assign(teaId, couId);
        }
    }
}
