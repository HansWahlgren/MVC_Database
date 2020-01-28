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

        [Required]
        public int StudentId { get; set; }
        [Required]
        public Student Student { get; set; }

        [Required]
        public int CourseId { get; set; }
        [Required]
        public Course Course { get; set; }
    }
}
