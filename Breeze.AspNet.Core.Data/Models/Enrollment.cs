using System.ComponentModel.DataAnnotations.Schema;

namespace Breeze.AspNet.Core.Data.Models
{
    public class Enrollment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Client must set the Id
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }

    public enum Grade
    {
        A, B, C, D, F
    }
}
