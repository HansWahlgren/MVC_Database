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
            return _assignmentRepository.All();
        }

        public Assignment Create(AssignmentViewModel assignment)
        {
            Assignment newAssignment = new Assignment()
            {
                Title = assignment.Title,
                Description = assignment.Description,
                Course = assignment.Course
            };
            return _assignmentRepository.Create(newAssignment);
        }

        public Assignment Find(int id)
        {
            return _assignmentRepository.Find(id);
        }

        public Assignment Assign(int assId, int couId)
        {
            return _assignmentRepository.Assign(assId, couId);
        }
    }
}
