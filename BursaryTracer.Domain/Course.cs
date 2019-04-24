using System.Collections.Generic;

namespace BursaryTracer.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

    }
}