using System.Collections.Generic;

namespace GradeBook.Models
{
    public class Student : User
    {
        public List<StudentCourse> StudentCourses { get; set; }
    }
}