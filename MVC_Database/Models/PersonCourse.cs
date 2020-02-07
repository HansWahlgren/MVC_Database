using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_Database.Models
{
    public class PersonCourse
    {
        [Key]
        public int Id { get; set; }


        public int StudentId { get; set; }

        public Student Student { get; set; }


        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
