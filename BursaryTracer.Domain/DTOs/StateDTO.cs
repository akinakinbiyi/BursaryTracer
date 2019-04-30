using System.Collections.Generic;

namespace BursaryTracer.Domain
{
    public class StateDTO
    {
        public int Id { get; set; }
        public string StateCode { get; set; }
        public string Name { get; set; }
        //public List<City>  Cities { get; set; }
        public int GovernorLists => Governors.Count;
        public ICollection<GovernorDTO> Governors { get; set; } = new List<GovernorDTO>();
        public int SchoolLists => Schools.Count;
        public ICollection<SchoolDTO> Schools { get; set; } = new List<SchoolDTO>();

    }
}