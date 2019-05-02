using System.ComponentModel.DataAnnotations.Schema;

namespace BursaryTracer.Domain
{
    public class Citizen
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        //public int Age { get; set; }
        //public int StateId { get; set; }
        //public int CourseId { get; set; }
        public double Amount { get; set; }
        //public int SchoolId { get; set; }
    }
}