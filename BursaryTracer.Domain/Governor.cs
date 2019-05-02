using System.ComponentModel.DataAnnotations.Schema;

namespace BursaryTracer.Domain
{
    public class Governor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartsTenure { get; set; }
        public string EndsTenure { get; set; }

        [ForeignKey("StateId")]
        public State State { get; set; }

        public int StateId { get; set; }
    }
}