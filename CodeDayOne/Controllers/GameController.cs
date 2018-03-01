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
            game.MinionList = game.LoadMinions();
            game.Player1 = game.ChampionList[player1Index];
            game.Player1Index = player1Index;
            game.Player2 = game.ChampionList[champIndex];
            game.Player2Index = champIndex;
            return View(game);
        }

        public ActionResult PartyMemberStats(int champIndex)
        {
            game.ChampionList = game.LoadChampions();
            game.Player1 = game.ChampionList[champIndex];
            game.Player1Index = champIndex;
            return PartialView(game);
        }

        public IActionResult BattleScreen(int player1Index, int player2Index)
        {
            game.ChampionList = game.LoadChampions();
            game.Player1 = game.ChampionList[player1Index];
            game.Player1Index = player1Index;
            game.Player2 = game.ChampionList[player2Index];
            game.Player2Index = player2Index;
            game.MinionList = game.LoadMinions();
            return View(game);
        }

        public void CreateMinionHorde()
        {
            game.MinionList = game.LoadMinions();
            game.BattleMinionList.Clear();
            Random random = new Random();
            int numberOfMinions = random.Next(1, 5);
            for (var i = 0; i < numberOfMinions; i++)
            {
                int index = random.Next(game.MinionList.Count);
                game.BattleMinionList.Add(game.MinionList.ElementAt(index));
            }
        }
    }
}