using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ActionResultDemo.Controllers
{
    public class StatusController : Controller
    {
        public IActionResult Index()
        {
            // return Ok();
            //return BadRequest();
            // return Unauthorized();
            return NotFound();
        }
    }
}