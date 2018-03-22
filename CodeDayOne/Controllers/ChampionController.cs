using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeDayOne.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeDayOne.Controllers
{
    public class ChampionController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            return View("Index");
        }
    }
}
