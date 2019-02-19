using GradeBook.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Services
{
    public class AssignmentRepo
    {
        private readonly GradeBookContext _ctx;

        public AssignmentRepo(GradeBookContext ctx)
        {
            _ctx = ctx;
        }

        public object GetCourseAssignments(int courseId)
        {
            var assingments = _ctx.Courses.Include(c => c.CourseAssignments).Where(c => c.Id == courseId);
                            

            return assingments;
        }

        public object GetAssignmentGrades(int assignmentId)
        {
            var grades = _ctx.CourseAssignments.Include(c => c.Grades).Where(c => c.Id == assignmentId);


            return grades;
        }
    }
}
