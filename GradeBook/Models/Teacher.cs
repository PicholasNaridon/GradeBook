using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Models
{
    public class Teacher : User
    {
        public List<Course> Courses { get; set; }
    }
}
