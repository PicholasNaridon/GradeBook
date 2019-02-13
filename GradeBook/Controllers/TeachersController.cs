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
    public class TeachersController : Controller
    {
        private readonly GradeBookContext _ctx;

        public TeachersController(GradeBookContext ctx)
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
                var result = _ctx.Teachers
                    .Where(t => t.Id == id)
                    .Include(x => x.Courses);

                return Ok(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine($" ran into some problemz {ex}");
                throw;
            }

        }

        [Route("[action]")]
        public IActionResult FindAll()
        {
            try
            {
                var teachers = _ctx.Teachers;

                var result = Json(teachers.Select(s => new
                {
                    s.Id,
                    s.FirstName,
                    s.LastName,
                    s.Email

                }));


                return Ok(result);
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
