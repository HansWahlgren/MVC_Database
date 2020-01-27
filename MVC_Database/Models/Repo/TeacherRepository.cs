using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public class TeacherRepository : ITeacherRepository
    {
        readonly SchoolDbContext _schoolDbContext;

        public TeacherRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public List<Teacher> All()
        {
            throw new NotImplementedException();
        }

        public Teacher Create(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public Teacher Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
