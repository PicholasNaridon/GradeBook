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

    }
}
