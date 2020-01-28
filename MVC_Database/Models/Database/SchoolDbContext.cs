using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> Assignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonCourse>()
                .HasKey(k => new { k.StudentId, k.CourseId });

            modelBuilder.Entity<PersonCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.PersonCourses)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<PersonCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.PersonCourses)
                .HasForeignKey(sc => sc.CourseId);
        }

    }
}