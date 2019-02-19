﻿using System.Collections.Generic;

namespace GradeBook.Models
{
    public class Student : User
    {
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public List<CourseAssignment> CourseAssignments { get; set; }
    }
}