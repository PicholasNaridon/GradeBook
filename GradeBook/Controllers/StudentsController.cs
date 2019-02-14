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
    public class StudentsController : Controller
    {
        private readonly StudentRepo _repo;

        public StudentsController(StudentRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Create([FromBody] Student student)
        {
            try
            {
                _repo.Insert(student);
                _repo.Save();
                return Ok(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong {ex}");
                throw;
            }

        }

        [Route("[action]")]
        [HttpPut]
        public IActionResult Update([FromBody] Student student)
        {
            _repo.Update(student);
            return Ok();
        }

        [Route("[action]/{id}")]
        public IActionResult FindById(int id)
        {
            var results = _repo.FindBy(id);
            return Ok(results);
        }

        [Route("[action]")]
        public IActionResult FindAll()
        {
            var results = _repo.GetAll();
            return Ok(results);
           
        }

        [Route("[action]")]
        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            _repo.Save();
            return Ok();
        }
    }
}
