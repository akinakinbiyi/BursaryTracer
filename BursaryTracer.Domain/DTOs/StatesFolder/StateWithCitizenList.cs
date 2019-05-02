using System.Collections.Generic;

namespace BursaryTracer.Domain.StatesFolder
{
    public class StateWithCitizenList
    {
        public int Id { get; set; }
        public string StateCode { get; set; }
        public string Name { get; set; }
        public int CitizenLists => Citizens.Count;
        public ICollection<Citizen> Citizens { get; set; } = new List<Citizen>();
    }
}