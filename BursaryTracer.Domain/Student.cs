namespace BursaryTracer.Domain
{
   public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }
        public Course  Course  { get; set; }
        public int CourseId { get; set; }
        public double Amount { get; set; }
    }
}
