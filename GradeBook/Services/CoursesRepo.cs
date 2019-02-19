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


        public object GetCourseDetails(int courseId)
        {
            var course = _ctx.Courses
                                .Include(c => c.StudentCourses)
                                    .ThenInclude(c => c.Student)
                                .Where(c => c.Id == courseId)
                                .FirstOrDefault();
            return course;
        }


        public object TeacherPlusCourses(int teacherId)
        {
           var results = _ctx.Teachers
                         .Include(t => t.Courses)
                            .ThenInclude(c => c.StudentCourses)
                                .ThenInclude(sc => sc.Student)
                         .Where(t => t.Id == teacherId)
                         .FirstOrDefault();

            
            foreach(var course in results.Courses)
            {
                foreach(var studentCourse in course.StudentCourses)
                {
                    studentCourse.Student.StudentCourses = null;
                    studentCourse.Student.password = null;
                    studentCourse.Student.IPAddress = null;

                }
            }
            

            return results;

        }

        public object TeachersPlusCourses(int teacherId)
        {
            var results = _ctx.Teachers
                          .Include(t => t.Courses)
                             .ThenInclude(c => c.StudentCourses)
                                 .ThenInclude(sc => sc.Student)
                          .ToList();

            foreach(var teacher in results)
            {
                foreach (var course in teacher.Courses)
                {
                    foreach (var studentCourse in course.StudentCourses)
                    {
                        studentCourse.Student.StudentCourses = null;
                        studentCourse.Student.password = null;
                        studentCourse.Student.IPAddress = null;

                    }
                }
            }
           
            return results;

        }

        public object Test(int teacherId)
        {
            var results = _ctx.Teachers
                          .Include(t => t.Courses)
                             .ThenInclude(c => c.StudentCourses)
                                 .ThenInclude(sc => sc.Student)
                          .ToList();

          

            return results;

        }
    }
}
