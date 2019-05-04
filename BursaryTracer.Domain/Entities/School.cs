using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BursaryTracer.Domain.Entities
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        [ForeignKey("StateId")]
        public State State { get; set; }

        public int StateId { get; set; }

        [ForeignKey("SchoolCategoryId")]
        public SchoolCategory SchoolCategory { get; set; }

        public int SchoolCategoryId { get; set; }
        public ICollection<Faculty> Faculties { get; set; }
        public ICollection<Student>  Students { get; set; }
    }
}