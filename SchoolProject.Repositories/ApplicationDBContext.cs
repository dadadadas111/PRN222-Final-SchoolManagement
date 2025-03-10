using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Repositories
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Session> YearlySessions { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Enroll> Enrolls { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AssignGrade>().HasOne(x => x.Grade)
                .WithMany(x => x.AssignGrades).HasForeignKey(x => x.GradeId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<AssignGrade>().HasOne(x => x.Teacher)
                .WithMany(x => x.AssignGrades).HasForeignKey(x => x.TeacherId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Enroll>().HasOne(x => x.Student)
                .WithMany(x => x.YearlySession).HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Enroll>().HasOne(x => x.Session)
                .WithMany(x => x.Enrollment).HasForeignKey(x => x.SessionId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Enroll>().HasOne(x => x.Grade)
                .WithMany(x => x.Enrolls).HasForeignKey(x => x.GradeId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<TeacherSession>().HasOne(x => x.Teacher)
                .WithMany(x => x.TeacherSessions).HasForeignKey(x => x.TeacherId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<TeacherSession>().HasOne(x => x.Session)
                .WithMany(x => x.TeacherSessions).HasForeignKey(x => x.SessionId)
                .OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(builder);
        }
    }
}
