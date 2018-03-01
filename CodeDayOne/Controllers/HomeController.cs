using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeDayOne.Models;

namespace CodeDayOne.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Game game = new Models.Game();

            ViewBag.championList = game.LoadChampions();
            ViewBag.minionList = game.LoadMinions();
            ViewBag.player1 = game.Player1;
            ViewBag.player2 = game.Player2;

            return View();
        }

        public void changeChampion(Champion champion)
        {
            
        }
    }
}
