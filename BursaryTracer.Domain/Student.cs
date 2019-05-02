﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BursaryTracer.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        //public int Age { get; set; }

        [ForeignKey("StateId")]
        public State State { get; set; }

        public int StateId { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        public int CourseId { get; set; }
        public double Amount { get; set; }

        //[ForeignKey("SchoolId")]
        //public School School { get; set; }

        //public int SchoolId { get; set; }
    }
}