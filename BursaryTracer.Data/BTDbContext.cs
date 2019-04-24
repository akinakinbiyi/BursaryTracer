using BursaryTracer.Domain;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace BursaryTracer.Data
{
    public class BTDbContext : DbContext
    {
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolCategory> SchoolCategories { get; set; }
        public DbSet<Governor> Governors { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }


        string MyServer = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFCCBursaryTracer;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(MyServer);
        }

        private readonly string filepath = @"C:\Users\akinakinbiyi\source\repos\BursaryTracer\BursaryTracer.Data\DataSeeders\";
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var state = JsonConvert.DeserializeObject<IEnumerable<State>>(File.ReadAllText(filepath + "States.json"));
            var cities = JsonConvert.DeserializeObject<IEnumerable<City>>(File.ReadAllText(filepath + "Cities.json"));
            var schoolCategories = JsonConvert.DeserializeObject<IEnumerable<SchoolCategory>>(File.ReadAllText(filepath + "SchoolCategory.json"));
            var school = JsonConvert.DeserializeObject<IEnumerable<School>>(File.ReadAllText(filepath + "Schools.json"));

            modelBuilder.Entity<State>().HasData(state);
            modelBuilder.Entity<City>().HasData(cities);
            modelBuilder.Entity<SchoolCategory>().HasData(schoolCategories);
            modelBuilder.Entity<School>().HasData(school);
        }
    }
}
