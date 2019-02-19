using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradeBook.Services;
using Microsoft.AspNetCore.Mvc;

namespace GradeBook.Controllers
{
    [Route("api/")]
    public class AssignmentsController : Controller
    {
        private readonly AssignmentRepo _repo;

        public AssignmentsController(AssignmentRepo repo)
        {
                _repo = repo;
        }
        [Route("course/{courseId}/[action]")]
        public IActionResult Assignments([FromRoute] int courseId)
        {
            var grades = _repo.GetCourseAssignments(courseId);
            return Ok(grades);
        }

        [Route("assignments/{id}/[action]")]
        public IActionResult Grades([FromRoute] int id)
        {
            var grades = _repo.GetAssignmentGrades(id);
            return Ok(grades);
        }
    }
}