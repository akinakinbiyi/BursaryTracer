using System.Collections.Generic;

namespace BursaryTracer.Domain.DTOs
{
    public class FacaultyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseLists => Courses.Count;

        public ICollection<CourseDto> Courses { get; set; } = new List<CourseDto>();
    }
}