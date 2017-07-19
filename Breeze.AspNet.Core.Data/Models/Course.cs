using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Breeze.AspNet.Core.Data.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Client must set the Id
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
