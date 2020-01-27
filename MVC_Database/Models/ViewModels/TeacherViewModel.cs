using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_Database.Models
{
    public class TeacherViewModel
    {
        [Required(ErrorMessage = "Must have a Name")]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Must have a name between 1 to 60 letters long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Must have a Email")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Email must be between 2 to 60 letters long")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Must have a Office")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Office must be between 2 to 60 letters long")]
        public string Office { get; set; }
    }
}
