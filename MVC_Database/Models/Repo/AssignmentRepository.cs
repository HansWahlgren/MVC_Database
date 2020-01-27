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
            throw new NotImplementedException();
        }

        public Assignment Create(Assignment assignment)
        {
            throw new NotImplementedException();
        }

        public Assignment Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
