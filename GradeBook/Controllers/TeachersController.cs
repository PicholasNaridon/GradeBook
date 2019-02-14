using GradeBook.Models;
using GradeBook.Services;
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
        private IGenericRepository<Teacher> _repo;

        public TeachersController(IGenericRepository<Teacher> repo)
        {
            _repo = repo;
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Create([FromBody] Teacher teacher)
        {
            try
            {
                _repo.Insert(teacher);
                return Ok(teacher);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong {ex}");
                throw;
            }

        }

        [Route("[action]/{id}")]
        [HttpPut]
        public IActionResult Update([FromBody] Teacher teacher)
        {
            _repo.Update(teacher);
            return Ok(teacher);
        }

        [Route("[action]/{id}")]
        public IActionResult FindById(int id)
        {
            var results = _repo.GetById(id);
            return Ok(results);
        }

        [Route("[action]")]
        public IActionResult FindAll()
        {
            var results = _repo.List();
            return Ok(results);

        }

        [Route("[action]")]
        public IActionResult Delete([FromBody] Teacher teacher)
        {
            _repo.Delete(teacher);
            return Ok();
        }
    }
}
