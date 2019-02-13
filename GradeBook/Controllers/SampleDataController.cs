using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradeBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace GradeBook.Controllers
{
    [Route("api/[controller]")]
    public class MainController : Controller
    {
        private readonly GradeBookContext _ctx;

        public MainController(GradeBookContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet("[action]")]
        public IActionResult Index()
        {

            var teach = new Teacher();
            _ctx.Teachers.Add(teach);

            return Ok(teach);
        }
    }
}
