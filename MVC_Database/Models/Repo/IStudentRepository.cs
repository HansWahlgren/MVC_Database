using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public interface IStudentRepository
    {
        Student Create(Student student);
        Student Find(int id);
        List<Student> All();
        Student Assign(int stuId, int couId);
    }
}
