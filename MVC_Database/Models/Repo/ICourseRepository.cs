using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public interface ICourseRepository
    {
        Course Create(Course course);
        Course Find(int id);
        List<Course> All();
    }
}
