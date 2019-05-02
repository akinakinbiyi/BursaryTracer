using BursaryTracer.Domain.CityFolder;
using BursaryTracer.Domain.SchoolFolder;
using System.Collections.Generic;

namespace BursaryTracer.Domain.StatesFolder
{
    public class StateDto
    {
        public int Id { get; set; }
        public string StateCode { get; set; }
        public string Name { get; set; }
        public int CityLists => Cities.Count;
        public ICollection<CityDto> Cities { get; set; } = new List<CityDto>();
        public int GovernorLists => Governors.Count;

        public ICollection<GovernorDTO> Governors { get; set; } = new List<GovernorDTO>();
        public int SchoolLists => Schools.Count;
        public ICollection<SchoolDTO> Schools { get; set; } = new List<SchoolDTO>();
        public int CitizenLists => Citizens.Count;
        public ICollection<Citizen>  Citizens { get; set; } = new List<Citizen>();

    }
}