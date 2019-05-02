using System.Collections.Generic;

namespace BursaryTracer.Domain.StatesFolder
{
    public class StateWithSchoolList
    {
        public int Id { get; set; }
        public string StateCode { get; set; }
        public string Name { get; set; }
        public int SchoolLists => Schools.Count;
        public ICollection<SchoolWithoutFacultyLists> Schools { get; set; } = new List<SchoolWithoutFacultyLists>();
    }
}