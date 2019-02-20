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
    public class TeachersAuthController : ControllerBase
    {
    
        private ITeacherService _teacherService;

        public TeachersAuthController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]Teacher userParam)
        {
            var user = await _teacherService.Authenticate(userParam.Email, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Email or password is incorrect" });

            return Ok(user);
        }

       
    }
    
}
