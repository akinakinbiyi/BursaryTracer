using System;
using System.Collections.Generic;
using System.Text;

namespace BursaryTracer.Domain
{
    public class Governor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TenureBegins { get; set; }
        public string TenureEnd { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }

    }
}
