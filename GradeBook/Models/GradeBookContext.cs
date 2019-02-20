using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Models
{
    public class GradeBookContext : DbContext
    {

        // UPDATING DATABASE
        // -------------------
        // From Package Manager Console
        // 1. Add-Migration <Migration_Name>
        // 2. Update-Database

        public GradeBookContext(DbContextOptions<GradeBookContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(s => new { s.StudentId, s.CourseId});

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherId);

            modelBuilder.Entity<School>()
                .HasOne(c => c.District)
                .WithMany(t => t.Schools)
                .HasForeignKey(c => c.DistrictId);

            //modelBuilder.Entity<Teacher>()
            //   .HasOne(c => c.School)
            //   .WithMany(t => t.Teachers)
            //   .HasForeignKey(c => c.SchoolId);


            //modelBuilder.Entity<Student>()
            //   .HasOne(s => s.School)
            //   .WithMany(s => s.Students)
            //   .HasForeignKey(s => s.SchoolId);

            modelBuilder.Entity<CourseAssignment>()
                .HasOne(a => a.Course)
                .WithMany(c => c.CourseAssignments)
                .HasForeignKey(c => c.CourseId);

            modelBuilder.Entity<Grade>()
                .HasOne(g => g.CourseAssignment)
                .WithMany(c => c.Grades)
                .HasForeignKey(c => c.CourseAssignmentId);

          
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set;}
        public DbSet<Grade> Grades { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<District> District { get; set; }


    }
}
