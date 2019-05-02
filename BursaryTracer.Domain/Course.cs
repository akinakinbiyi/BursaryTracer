using System.ComponentModel.DataAnnotations.Schema;

namespace BursaryTracer.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("FacultyId")]
        public Faculty Faculty { get; set; }

        public int FacultyId { get; set; }
        //public List<Student> Students { get; set; }
    }
}