﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BursaryTracer.Domain.DTOs
{
  public  class FacaultyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseLists => Courses.Count;

        public ICollection<CourseDTO> Courses { get; set; } = new List<CourseDTO>();

    }
}
