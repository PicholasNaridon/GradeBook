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

        public object getCourseGrades(int courseId)
        {
            var grades = _ctx.Courses
                            .Include(c => c.CourseAssignments)
                            .Where(c => c.Id == courseId);
                            

            return grades;
        }
    }
}
