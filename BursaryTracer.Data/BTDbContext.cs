using BursaryTracer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace BursaryTracer.Data
{
    public class BTDbContext : DbContext
    {
        public BTDbContext(DbContextOptions<BTDbContext> options)
            : base(options)
        { }

        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolCategory> SchoolCategories { get; set; }
        public DbSet<Governor> Governors { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        private readonly string MyServer = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BursaryTracerApiDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(MyServer);
        }

        private readonly string filepath = @"C:\Trainings\BursaryTracer\BursaryTracer.Data\DataSeeders\";

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var state = JsonConvert.DeserializeObject<IEnumerable<State>>(File.ReadAllText(filepath + "States.json"));
            var cities = JsonConvert.DeserializeObject<IEnumerable<City>>(File.ReadAllText(filepath + "Cities.json"));
            var schoolCategories = JsonConvert.DeserializeObject<IEnumerable<SchoolCategory>>(File.ReadAllText(filepath + "SchoolCategory.json"));
            var school = JsonConvert.DeserializeObject<IEnumerable<School>>(File.ReadAllText(filepath + "School.json"));
            var governors = JsonConvert.DeserializeObject<IEnumerable<Governor>>(File.ReadAllText(filepath + "Governor.json"));
            var faculty = JsonConvert.DeserializeObject<IEnumerable<Faculty>>(File.ReadAllText(filepath + "Faculty.json"));
            var course = JsonConvert.DeserializeObject<IEnumerable<Course>>(File.ReadAllText(filepath + "Course.json"));
            var student = JsonConvert.DeserializeObject<IEnumerable<Student>>(File.ReadAllText(filepath + "Students.json"));


            modelBuilder.Entity<City>().HasData(cities);
            modelBuilder.Entity<SchoolCategory>().HasData(schoolCategories);
            modelBuilder.Entity<Faculty>().HasData(faculty);
            modelBuilder.Entity<Course>().HasData(course);

            modelBuilder.Entity<Student>(s => {
                s.HasData(student);
                //s.HasOne(c => c.State).WithMany(t => t.Students).OnDelete(DeleteBehavior.SetNull);
            });

            //modelBuilder.Entity<Student>().HasOne(s=>s.Course).WithMany(c=>c.Students);


            modelBuilder.Entity<School>(s =>
            {
                s.HasData(school);
                s.HasMany(f => f.Faculties);
            });

            modelBuilder.Entity<State>(s =>
            {
                s.HasData(state);
                s.HasMany(g => g.Governors);
                s.HasMany(st => st.Students);
            });

            modelBuilder.Entity<Governor>(g =>
            {
                g.HasData(governors);
                g.HasOne(s => s.State).WithMany(sg => sg.Governors).HasForeignKey(s => s.StateId);
            });

            ////modelBuilder.Entity<Student>(s =>
            ////{
            ////    //s.HasOne(o => o.State).WithMany(st=> st.Students)/*.OnDelete(DeleteBehavior.SetNull)*/;
            ////    s.HasOne(o => o.School).WithMany(st => st.Students);
            ////    s.HasOne(o => o.Course).WithMany(st => st.Students);

            //});
        }
    }
}