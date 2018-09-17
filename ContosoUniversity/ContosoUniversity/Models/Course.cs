using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Course
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [Key]
        public int id { get; set; }


        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(25, ErrorMessage = "la longitud del campo es de 25 caracteres")]
        [DataType(DataType.Text)]
        public String Title { get; set; }


        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Credits { get; set; }


        /// <summary>
        /// Relacion entre tablas Enrollment - Course
        /// </summary>
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}