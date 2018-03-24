using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using CodeDayOne.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodeDayOne.Controllers
{
    public class GameController : Controller
    {
        public IActionResult GameBoard()
        {
            
            return View();
        }
    }
}