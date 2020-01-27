using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public interface IAssignmentRepository
    {
        Assignment Create(Assignment assignment);
        Assignment Find(int id);
        List<Assignment> All();
    }
}
