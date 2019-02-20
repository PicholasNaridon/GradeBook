using GradeBook.Models;
using GradeBook.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class StudentsAuthController : ControllerBase
    {

        private IStudentService _studentService;

        public StudentsAuthController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]Teacher userParam)
        {
            var user = await _studentService.Authenticate(userParam.Email, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Email or password is incorrect" });

            return Ok(user);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _studentService.GetAll();
            return Ok(users);
        }
    }

}
