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


        private readonly CoursesRepo _coursesRepo;
        private readonly GradeBookContext _ctx;

        public CoursesController(IGenericRepository<Teacher> teacherRepo, CoursesRepo couresesRepo, GradeBookContext ctx)
        {
            _coursesRepo = couresesRepo;
            _ctx = ctx;
        }

        // List teacher with all courses
        [Route("[action]")]
        public IActionResult All([FromRoute] int teacherId)
        {
            var results = _coursesRepo.GetTeacherCourses(teacherId);

            return Ok(results);
        }

       
        //List teacher with all courses and associated students
        [Route("[action]")]
        public IActionResult AllDetails([FromRoute] int teacherId)
        {
            var results = _coursesRepo.TeacherPlusCourses(teacherId);

            return Ok(results);
        }

        //List Course Details and students
        [Route("[action]/{courseId}")]
        public IActionResult Details([FromRoute] int courseId)
        {
            var results = _coursesRepo.GetCourseDetails(courseId);

            return Ok(results);
        }


        [Route("[action]")]
        public IActionResult Test([FromRoute] int teacherId)
        {
            var results = _coursesRepo.Test(teacherId);

            return Ok(results);
        }

    }
}
