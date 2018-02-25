using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeDayOne.Models;

namespace CodeDayOne.Controllers
{
    public class GameController : Controller
    {
        public Game game = new Game();


        // GET: Game
        public IActionResult PartySelect()
        {
            game.ChampionList = game.LoadChampions();
            
            return View(game);
        }

        public ActionResult ChangeChampion(int champIndex)
        {
            game.ChampionList = game.LoadChampions();
            game.Player1 = game.ChampionList[champIndex];
            Console.Write("Party Member #1: " + game.Player1.Name);
            return View(game);
        }
    }
}