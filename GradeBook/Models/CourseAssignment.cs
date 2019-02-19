using GradeBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Models
{
    public class CourseAssignment : EntityBase
    {

        public Course Course { get; set; }
        public int CourseId { get; set; }

        public string Type { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Grade> Grades { get; set;}
    }
}
