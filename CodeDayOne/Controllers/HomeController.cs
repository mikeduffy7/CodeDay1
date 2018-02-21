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
            //var champ1 = new Champion("Sona", 100, 10, 10, 15, 12, 20, new List<Ability>(), 40);
            //champ1.AbilityList.Add(new Ability("Hymn of Valor", 3, Ability.Damage_Type.magic, 5));
            //champ1.AbilityList.Add(new Ability("Aria of Perseverence", 5, Ability.Damage_Type.magic, 10));
            //champ1.AbilityList.Add(new Ability("Song of Celerity", 8, Ability.Damage_Type.magic, 10));
            //champ1.AbilityList.Add(new Ability("Crescendo", 15, Ability.Damage_Type.magic, 30));
 
            //return View("Index", champ1);

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Game()
        {
            return View();
        }
    }
}
