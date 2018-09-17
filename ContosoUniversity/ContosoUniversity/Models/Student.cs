using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(30, ErrorMessage = "la longitud del campo es de 30 caracteres" )]
        [DataType(DataType.Text)]
        public String LastName { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(30, ErrorMessage = "la longitud del campo es de 30 caracteres")]
        [DataType(DataType.Text)]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        /// <summary>
        /// Relacion entre tablas Enrollment - Student
        /// </summary>
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}