using System.ComponentModel.DataAnnotations.Schema;

namespace BursaryTracer.Domain
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("StateId")]
        public State State { get; set; }
        public int StateId { get; set; }
    }
}