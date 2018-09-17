using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Department
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(30, ErrorMessage = "La longitud del campo es de 30 caracteres")]
        public String Name { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [DataType(DataType.Currency)]
        public Double Budget { get; set; }

        
        [Required(ErrorMessage = "El campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [ForeignKey("Instructor")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        /// <summary>
        /// Relacion Course - Department
        /// </summary>
        public virtual ICollection<Course> Courses { get; set; }


    }
}