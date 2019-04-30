using System.Collections.Generic;

namespace BursaryTracer.Domain
{
    public class StateDTO
    {
        public int Id { get; set; }
        public string StateCode { get; set; }
        public string Name { get; set; }
        //public List<City>  Cities { get; set; }
        //public List<School> Schools { get; set; }
        public int GovernorLists
        {
            get
            {
                return Governors.Count;
            }
        }
        public ICollection<Governor> Governors { get; set; } = new List<Governor>();
    }
}