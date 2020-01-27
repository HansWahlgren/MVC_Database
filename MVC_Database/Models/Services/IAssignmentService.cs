using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public interface IAssignmentService
    {
        Assignment Create(AssignmentViewModel assignment);
        Assignment Find(int id);
        List<Assignment> All();
    }
}
