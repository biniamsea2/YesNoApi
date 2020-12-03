using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YesNoApp.Models.Interfaces;

namespace YesNoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        //DP:
        private readonly IYesNo _context;
        private Random randomNum = new Random();

        public HomeController(IYesNo yesNo)
        {
            _context = yesNo;
        }
        //get method that will get one random yes or no from our db and return it:
        [HttpGet]
        public async Task<IActionResult> GetOneRandomYesNo()
        {
            //Next will get the next number after our random number. Ex: random = 7. random.next = 8:
            int id = randomNum.Next(1, 10);
            return Ok(await _context.GetSinlgeYesNoRandom(id));
        }
        //will get a specific yes or no from our database by using the ID given to us by the user:
        [HttpGet("{id}")]
        public async Task<ActionResult> GetOneYesOrNoById(int id)
        {
            return Ok(await _context.GetYesNoByID(id));
        }
    }
}