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

        public ActionResult SelectPartyMember1(int champIndex)
        {
            game.ChampionList = game.LoadChampions();
            game.Player1 = game.ChampionList[champIndex];
            game.Player1Index = champIndex;
            return View(game);
        }
        public ActionResult SelectPartyMember2(int champIndex, int player1Index)
        {
            game.ChampionList = game.LoadChampions();
            game.Player1 = game.ChampionList[player1Index];
            game.Player1Index = player1Index;
            game.Player2 = game.ChampionList[champIndex];
            game.Player2Index = champIndex;
            return View(game);
        }
    }
}