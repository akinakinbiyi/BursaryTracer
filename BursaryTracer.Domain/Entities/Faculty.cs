using System.Collections.Generic;

namespace BursaryTracer.Domain.Entities
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public School School { get; set; }
        //public int SchoolId { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}