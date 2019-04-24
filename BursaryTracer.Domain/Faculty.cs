using System;
using System.Collections.Generic;
using System.Text;

namespace BursaryTracer.Domain
{
  public  class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Course { get; set; }
        public int CourseId { get; set; }
        public School School { get; set; }
        public int SchoolId { get; set; }
    }
}
