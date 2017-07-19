using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Breeze.AspNet.Core.Data.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Client must set the Id
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}
