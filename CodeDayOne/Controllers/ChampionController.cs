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
            var champ1 = new Champion("Sona", 100, 10, 10, 15, 12, 20, new List<Ability>(), 40);
            champ1.AbilityList.Add(new Ability("Hymn of Valor", 3, Ability.Damage_Type.magic, 5));
            champ1.AbilityList.Add(new Ability("Aria of Perseverence", 5, Ability.Damage_Type.magic, 10));
            champ1.AbilityList.Add(new Ability("Song of Celerity", 8, Ability.Damage_Type.magic, 10));
            champ1.AbilityList.Add(new Ability("Crescendo", 15, Ability.Damage_Type.magic, 30));

            ViewBag.ChampionData = champ1;

            var character = new Character("Sona");
            ViewData["Sona"] = character;



            return View("Index");
        }
    }
}
