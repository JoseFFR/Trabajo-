using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        /// <summary>
        /// Foreign Key - instructor
        /// </summary>
        [ForeignKey("Instructor")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [DataType(DataType.Text)]
        public String Location { get; set; }

        /// <summary>
        /// Relacion Instructor - Office
        /// </summary>
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}