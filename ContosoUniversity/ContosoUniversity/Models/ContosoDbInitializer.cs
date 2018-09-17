using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class ContosoDbInitializer : DropCreateDatabaseIfModelChanges<ContosoContext>
    {
        protected override void Seed(ContosoContext DbCtx)
        {
            List<Student> Students = new List<Student>();
            Students.Add(new Student()
            {
                LastName = " ",
                FirstName = " ",
                EnrollmentDate = DateTime.Now
            });
            DbCtx.Students.AddRange(Students);
            DbCtx.SaveChanges();
        }
    }
}