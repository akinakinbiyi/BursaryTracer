using System;
using System.Collections.Generic;
using System.Text;

namespace BursaryTracer.Domain
{
    public class Governor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartsTenure { get; set; }
        public string EndsTenure { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }


    }
}
