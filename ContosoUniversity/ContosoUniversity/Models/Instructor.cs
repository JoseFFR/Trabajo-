using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(25, ErrorMessage = "La longitud del campo es de 25 caracteres")]
        [DataType(DataType.Text)]
        public String LastName { get; set; }


        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(25, ErrorMessage = "La longitud del campo es de 25 caracteres")]
        [DataType(DataType.Text)]
        public String FirstMidName { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [DataType(DataType.Date]
        public DateTime HireDate { get; set; }

        /// <summary>
        /// Relacion Course - Instructor
        /// </summary>
        public virtual ICollection<Course> Courses { get; set; }

        /// <summary>
        /// RELACION OFFICE - INSTRUCTOR
        /// </summary>
        public virtual ICollection<OfficeAssignment> OfficeAssignments { get; set; }




    }
}