using System.Collections.Generic;

namespace BursaryTracer.Domain.StatesFolder
{
    public class StateWithGovernorList
    {
        public int Id { get; set; }
        public string StateCode { get; set; }
        public string Name { get; set; }
        public int GovernorLists => Governors.Count;
        public ICollection<GovernorDTO> Governors { get; set; } = new List<GovernorDTO>();
    }
}