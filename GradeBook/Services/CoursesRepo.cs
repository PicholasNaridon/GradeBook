using GradeBook.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Services
{
    public class CoursesRepo
    {
        private readonly GradeBookContext _ctx;

        public CoursesRepo(GradeBookContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Teacher> GetTeacherCourses(int teacherId)
        {
            return _ctx.Teachers.Include(t => t.Courses).Where(t => t.Id == teacherId);
        }
    }
}
