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

        public IQueryable GetCourse(int courseId)
        {
            //var results = from course in _ctx.Courses
            //              join studentCourse in _ctx.StudentCourses on course.Id equals studentCourse.CourseId
            //              join 
            //              where course.Id == courseId
            //              select course studentCourse;

            //var results = _ctx.StudentCourses
            //                .Include(x => x.Student)
            //                .Include(x => x.Course)
            //                .Where(x => x.CourseId == courseId);
            //return results;


            var StudentCourses = (from sc in _ctx.StudentCourses
                                  join s in _ctx.Students on sc.StudentId equals s.Id
                                  join c in _ctx.Courses on sc.CourseId equals c.Id
                                  select new
                                  {
                                      teacher = c.Teacher,
                                      course = new
                                      {
                                          id = c.Id,
                                          name = c.Name,
                                      },
                                      student = new
                                      {
                                          id = s.Id,
                                          firstName = s.FirstName,
                                          lastName = s.LastName,
                                          email = s.Email

                                      }
                                  });

            return StudentCourses;
           
        }

        public IQueryable StudentsByCourse(int courseId)
        {
            var course = _ctx.Courses
                 .Where(c => c.Id == courseId)
                 .SelectMany(p => p.StudentCourses)
                 .Select(sc => sc.Student)
                 .


            return course;
        }
    }
}
