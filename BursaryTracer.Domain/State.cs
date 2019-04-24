using System.Collections.Generic;

namespace BursaryTracer.Domain
{
    public class State
    {
        public int Id { get; set; }
        public string StateCode { get; set; }
        public string Name { get; set; }
        public List<City>  Cities { get; set; }

    }
}
