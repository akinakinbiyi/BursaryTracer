using BursaryTracer.Domain.Entities;
using System.Collections.Generic;

namespace BursaryTracer.Domain
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Citizen> Students { get; set; }
    }
}