using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public interface IStudentService
    {
        Student Create(StudentViewModel student);
        Student Find(int id);
        List<Student> All();
    }
}
