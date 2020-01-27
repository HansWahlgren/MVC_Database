using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public class AssignmentRepository : IAssignmentRepository
    {
        readonly SchoolDbContext _schoolDbContext;

        public AssignmentRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public List<Assignment> All()
        {
            return _schoolDbContext.Assignments.ToList();
        }

        public Assignment Create(Assignment assignment)
        {
            _schoolDbContext.Assignments.Add(assignment);
            _schoolDbContext.SaveChanges();

            return assignment;
        }

        public Assignment Find(int id)
        {
            return _schoolDbContext.Assignments.SingleOrDefault(assignment => assignment.Id == id);
        }
    }
}
