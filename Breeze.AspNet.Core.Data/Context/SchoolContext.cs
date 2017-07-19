using Breeze.AspNet.Core.Data.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Breeze.AspNet.Core.Data.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base(nameOrConnectionString: "SchoolContext")
        {
            // Disable proxy creation as this messes up the data service.
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public SchoolContext(string connString) : base(connString)
        {
            // Disable proxy creation as this messes up the data service.
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
