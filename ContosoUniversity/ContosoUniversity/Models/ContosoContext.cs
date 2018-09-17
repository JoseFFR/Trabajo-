using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ContosoContext : DbContext
    {

        public ContosoContext() : base ("ContosoContext")
        {
            Database.SetInitializer<ContosoContext>(new ContosoDbInitializer());
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Student> Students { get; set; }


        //COnfigurar la pluralizacion de las tablas
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Eliminar la config. de colocar las tablas de singular a plural o viceversa
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}