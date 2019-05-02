using BursaryTracer.Domain.CityFolder;
using System.Collections.Generic;

namespace BursaryTracer.Domain.StatesFolder
{
    public class StateWithCityList
    {
        public int Id { get; set; }
        public string StateCode { get; set; }
        public string Name { get; set; }
        public int CityLists => Cities.Count;
        public ICollection<CityDto> Cities { get; set; } = new List<CityDto>();
    }
}