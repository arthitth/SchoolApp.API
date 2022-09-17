using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.API.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //[Authorize(Roles = UserRoles.Student+","+ UserRoles.Manager)]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {
        }

        [HttpGet("student")]
        [Authorize(Roles = UserRoles.Student)]
        public IActionResult GetStudent()
        {
            return Ok("Welcome to HomeController - Student");
        }

        [HttpGet("manager")]
        [Authorize(Roles = UserRoles.Manager)]
        public IActionResult GetManager()
        {
            return Ok("Welcome to HomeController - Manager");
        }
    }
}
