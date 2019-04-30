using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BursaryTracer.Domain
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public List<Student> Students { get; set; }

    }
}