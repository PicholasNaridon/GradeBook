using GradeBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        private readonly GradeBookContext _ctx;

        public StudentsController(GradeBookContext ctx)
        {
            _ctx = ctx;
        }

        [Route("[action]")]
        public IActionResult Create()
        {
            throw new NotImplementedException();
        }

        [Route("[action]")]
        public IActionResult Update()
        {
            throw new NotImplementedException();
        }

        [Route("[action]/{id}")]
        public IActionResult FindById(int id)
        {
            try
            {
                var result = _ctx.Students
                      .Where(s => s.Id == id)
                      .Include(x => x.StudentCourses)
                      .ThenInclude(x => x.Course);
                return Ok(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine($" ran into some problemz {ex}");
                throw;
            }
           
            throw new NotImplementedException();
        }

        [Route("[action]")]
        public IActionResult FindAll()
        {
            try
            {
                var student = _ctx.Students
                    .Include(s => s.StudentCourses)
                    .ThenInclude(s => s.Course);
                   
                //var result = student.Select(s => new
                //{
                //    s.StudentCourses.FirstOrDefault(),
                //    s.Id,
                //    s.FirstName,

                //})

               
                //var result = Json(student.Select(s => new
                //{
                //    s.Id,
                //    s.FirstName,
                //    s.LastName,
                //    s.Email

                //}));


                return Ok(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine($" ran into some problemz {ex}");
                throw;
            }
           
        }

        [Route("[action]")]
        public IActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
