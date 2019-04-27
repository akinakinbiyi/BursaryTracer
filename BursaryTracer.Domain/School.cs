using System.Collections.Generic;

namespace BursaryTracer.Domain
{
   public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }
        public SchoolCategory SchoolCategory { get; set; }
        public int SchoolCategoryId { get; set; }
        public List<Faculty>  Faculties { get; set; }
    }
}
