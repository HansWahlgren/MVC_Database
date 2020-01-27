using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_Database.Models
{
    public class AssignmentViewModel
    {
        [Required(ErrorMessage = "Must have a Title")]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Must have a title between 1 to 60 letters long")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Must have a Description")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "Description must be between 10 to 200 long")]
        public string Description { get; set; }

        public int Course { get; set; }
    }
}
