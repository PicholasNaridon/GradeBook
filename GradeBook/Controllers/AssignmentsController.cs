using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradeBook.Services;
using Microsoft.AspNetCore.Mvc;

namespace GradeBook.Controllers
{
    [Route("api/course/{courseId}")]
    public class AssignmentsController : Controller
    {
        private readonly AssignmentRepo _repo;

        public AssignmentsController(AssignmentRepo repo)
        {
                _repo = repo;
        }
        [Route("[action]")]
        public IActionResult Assignments([FromRoute] int courseId)
        {
            var grades = _repo.getCourseGrades(courseId);
            return Ok(grades);
        }
    }
}