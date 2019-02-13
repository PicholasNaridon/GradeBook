using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
    }
}
