using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public class AssignmentService : IAssignmentService
    {
        readonly IAssignmentRepository _assignmentRepository;

        public AssignmentService(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public List<Assignment> All()
        {
            throw new NotImplementedException();
        }

        public Assignment Create(AssignmentViewModel assignment)
        {
            throw new NotImplementedException();
        }

        public Assignment Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
