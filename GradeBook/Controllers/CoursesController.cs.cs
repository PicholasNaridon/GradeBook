using GradeBook.Models;
using GradeBook.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace GradeBook.Controllers
{
    [Route("api/Teacher/{teacherId}/[controller]")]
    public class CoursesController : Controller
    {


        private readonly IGenericRepository<Teacher> _teacherRepo;
        private readonly CoursesRepo _coursesRepo;
        private readonly GradeBookContext _ctx;

        public CoursesController(IGenericRepository<Teacher> teacherRepo, CoursesRepo couresesRepo, GradeBookContext ctx)
        {
            _teacherRepo = teacherRepo;
            _coursesRepo = couresesRepo;
            _ctx = ctx;
        }
         [Route("[action]")]
        public IActionResult Main()
        {
            var results = _coursesRepo.StudentsByCourse(2);

            return Ok(results);
        }

        [Route("[action]")]
        public IActionResult Index([FromRoute] int teacherId)
        {
            var results = _coursesRepo.GetTeacherCourses(teacherId);

            return Ok(results);
        }

        [Route("[action]/{courseId}")]
        public IActionResult Course([FromRoute] int courseId)
        {
            var results = _coursesRepo.GetCourse(courseId);

            return Ok(results);
        }


        [Route("[action]/{courseId}")]
        public IActionResult CoursePlus([FromRoute] int courseId)
        {
            var results = _coursesRepo.CoursePlus(courseId);

            return Ok(results);
        }

        [Route("[action]/{courseId}")]
        public IActionResult A([FromRoute] int courseId)
        {
            var results = _coursesRepo.A(courseId);

            return Ok(results);
        }

        [Route("[action]")]
        public IActionResult GetTeacherCourses([FromRoute] int teacherId)
        {
            var results = _coursesRepo.B(teacherId);

            return Ok(results);
        }

    }
}
