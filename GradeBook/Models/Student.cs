using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradeBook.Models
{
    public class Student : User
    {
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }

        //public int SchoolId { get; set; }
        //public School School { get; set; }
    }
}