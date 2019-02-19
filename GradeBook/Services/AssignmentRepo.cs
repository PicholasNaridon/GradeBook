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
            var assingments = _ctx.Courses.Include(c => c.CourseAssignments).Where(c => c.Id == courseId).FirstOrDefault();
                            

            return assingments;
        }

        public object GetAssignmentGrades(int assignmentId)
        {
            var grades = _ctx.CourseAssignments.Include(c => c.Grades).ThenInclude(c => c.Student).Where(c => c.Id == assignmentId).FirstOrDefault();


            return grades;
        }
    }
}
