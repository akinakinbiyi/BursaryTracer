using BursaryTracer.Domain.DTOs;
using System.Collections.Generic;

namespace BursaryTracer.Domain.SchoolFolder
{
    public class SchoolDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        //public State State { get; set; }
        public int StateId { get; set; }
        //public SchoolCategory SchoolCategory { get; set; }
        public int SchoolCategoryId { get; set; }

        public int FacultyCount => Faculties.Count;

        public ICollection<FacaultyWithoutCourseList> Faculties { get; set; } = new List<FacaultyWithoutCourseList>();
    }
}