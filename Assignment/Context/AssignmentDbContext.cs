using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Configuration;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Context
{
    public class AssignmentDbContext : DbContext
    {
        //Fluent Api

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Course-Fluent APIs
            modelBuilder.Entity<Course>().HasKey(c => c.ID);
            
            modelBuilder.Entity<Course>()
                        .Property(C => C.Name)
                        .IsRequired()
                        .HasMaxLength(50);
            
            modelBuilder.Entity<Course>()
                        .Property(C => C.Duration)
                        .IsRequired();
            
            modelBuilder.Entity<Course>()
                        .Property(C => C.Description)
                        .HasMaxLength(255);
            
            modelBuilder.Entity<Course>()
                        .Property(C => C.Top_ID)
                        .IsRequired();
            #endregion


            #region ConfigurationClasses
            //Instructor
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());

            //Topic
            modelBuilder.ApplyConfiguration(new TopicConfiguration());

            //Student
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            #endregion

            modelBuilder.Entity<Course_Inst>()
                        .HasKey(ci => new { ci.Course_ID, ci.Inst_ID });

            modelBuilder.Entity<Stud_Course>()
                        .HasKey(SC => new { SC.Course_ID, SC.Stud_ID });

            base.OnModelCreating(modelBuilder);
        }

        public AssignmentDbContext() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = Assignment; Trusted_Connection = True; TrustServerCertificate = True"); ;
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> StudCourses { get; set; }
        public DbSet<Course_Inst> CourseInsts { get; set; }
    }
}
