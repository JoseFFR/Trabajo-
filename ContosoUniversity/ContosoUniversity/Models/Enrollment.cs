using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Enrollment
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Foreign key - Course
        /// </summary>
        [ForeignKey("Course")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int CourseId { get; set; }
        public Course Course { get; set; }


        /// <summary>
        /// Foreign Key - Student
        /// </summary>
        [ForeignKey("Student")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int IdStudent { get; set; }
        public Student Student { get; set; }


        [Required(ErrorMessage = "El campo es obligatorio")]
        [DataType(DataType.Text)]
        public String Grade { get; set; }

        /// <summary>
        /// Relacion Student - Enrollment
        /// </summary>
        public virtual ICollection<Student> Students { get; set; }

        /// <summary>
        /// Relacion Course - Enrollment
        /// </summary>
        public virtual ICollection<Course> Courses { get; set; }


    }
}