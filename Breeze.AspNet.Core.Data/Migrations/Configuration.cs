namespace Breeze.AspNet.Core.Data.Migrations
{
    using Breeze.AspNet.Core.Data.Context;
    using Breeze.AspNet.Core.Data.Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolContext context)
        {
            context.Students.AddOrUpdate(
                el => el.Id,
                new Student { Id = 1, FirstName = "Dick", LastName = "Tator", EnrollmentDate = DateTime.Now.AddDays(-20) },
                new Student { Id = 2, FirstName = "Miss", LastName = "Tress", EnrollmentDate = DateTime.Now.AddDays(-10) });

            context.Courses.AddOrUpdate(
                el => el.Id,
                new Course { Id = 1, Credits = 8, Title = "Using Breeze with ASP.NET Core" },
                new Course { Id = 2, Credits = 9, Title = "Intro EF 6" });

            context.Enrollments.AddOrUpdate(
                el => el.Id,
                new Enrollment { Id = 1, CourseId = 1, StudentId = 1, Grade = Grade.B },
                new Enrollment { Id = 2, CourseId = 1, StudentId = 2, Grade = Grade.A },
                new Enrollment { Id = 3, CourseId = 2, StudentId = 2, Grade = Grade.A }
                );
        }
    }
}
