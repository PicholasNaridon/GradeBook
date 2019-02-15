using GradeBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Models
{
    public class Assignment : EntityBase
    {


        public Course Course { get; set; }
        public int CourseId { get; set; }

        public string Type { get; set; }
        public string Name { get; set; }

        public Student Student { get; set; }
        public int StudentId { get; set; }




    }
}
