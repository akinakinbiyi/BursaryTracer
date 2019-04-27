using System.Collections.Generic;

namespace BursaryTracer.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Faculty  Faculty { get; set; }
        public int FacultyId { get; set; }
        public List<Student> Students { get; set; }

    }
}