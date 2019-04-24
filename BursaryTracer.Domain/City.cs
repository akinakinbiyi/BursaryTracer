using System;
using System.Collections.Generic;
using System.Text;

namespace BursaryTracer.Domain
{
   public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }
    }
}
