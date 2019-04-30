using System.Collections.Generic;

namespace BursaryTracer.Domain
{
    public class State
    {
        public int Id { get; set; }
        public string StateCode { get; set; }
        public string Name { get; set; }
        //public ICollection<City> Cities { get; set; }
        public ICollection<School> Schools { get; set; }

        public ICollection<Governor> Governors { get; set; } 
    }
}