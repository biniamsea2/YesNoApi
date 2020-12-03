using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YesNoApp.Controllers
{
    public class home : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello from controller");
        }
    }
}