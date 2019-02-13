using GradeBook.Models;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        [Route("[action]")]
        public IActionResult FindById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult FindAll()
        {
            throw new NotImplementedException();
        }

        [Route("[action]")]
        public IActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
