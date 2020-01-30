using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public interface ITeacherRepository
    {
        Teacher Create(Teacher teacher);
        Teacher Find(int id);
        List<Teacher> All();
        Teacher Assign(int teaId, int couId);
    }
}
