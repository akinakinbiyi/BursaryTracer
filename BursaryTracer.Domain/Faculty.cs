using System;
using System.Collections.Generic;
using System.Text;

namespace BursaryTracer.Domain
{
  public  class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public int CourseId { get; set; }
        //public School School { get; set; }
        //public int SchoolId { get; set; }

        public int CourseLists
        {
            get
            {
                return Courses.Count;
            }
        }
    }
}
