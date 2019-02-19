using GradeBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Models
{
    public class Course : EntityBase
    {
        public string Name { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public virtual ICollection<Assignment> Assignments { get;  set; }
    }
}
