﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeDayOne.Models;
using CodeDayOne.ViewModels;

namespace CodeDayOne.Controllers
{
    public class BattleController : Controller
    {
        BattleViewModel globalModel = new BattleViewModel();
        public IActionResult Index(int partyMember1Id, int partyMember2Id)
        {
            var champions = LoadChampions();
            var viewModel = new BattleViewModel
            {
                BattleMinionList = CreateHorde(NumberOfMinionsInHorde()),
                Party = new Party(), 
                PartyMember1 = champions.SingleOrDefault(c => c.ID == partyMember1Id),
                PartyMember2 = champions.SingleOrDefault(c => c.ID == partyMember2Id),
                IsRed = MinionsAreRed()
            };
            viewModel.PartyMember1.ID = 1;
            viewModel.PartyMember2.ID = 2;
            foreach (var minion in viewModel.BattleMinionList)
            {
                viewModel.BattleOrder.Add(minion);
            }
            viewModel.BattleOrder.Add(viewModel.PartyMember1);
            viewModel.BattleOrder.Add(viewModel.PartyMember2);

            viewModel.BattleOrder = viewModel.BattleOrder.OrderByDescending(o => o.AttackSpeed).ToList();

            globalModel = viewModel;
            return View(viewModel);
        }

        public List<Minion> LoadMinions()
        {
            var MinionList = new List<Minion>();

            var meleeMinion = new Minion("Melee Minion", 455, 2, 12, 0, 0, 20, 59);
            meleeMinion.BlueImageURL = "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/65/Blue_Melee_MinionSquare.png/revision/latest/scale-to-width-down/48?cb=20140731204557";
            meleeMinion.RedImageURL = "https://vignette.wikia.nocookie.net/leagueoflegends/images/e/ea/Red_Melee_MinionSquare.png/revision/latest/scale-to-width-down/48?cb=20140731204552";

            var casterMinion = new Minion("Caster Minion", 308, 10, 22, 0, 0, 17, 29);
            casterMinion.BlueImageURL = "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/fa/Blue_Caster_MinionSquare.png/revision/latest/scale-to-width-down/48?cb=20140731204553";
            casterMinion.RedImageURL = "https://vignette.wikia.nocookie.net/leagueoflegends/images/1/10/Red_Caster_MinionSquare.png/revision/latest/scale-to-width-down/48?cb=20140731204552";

            var siegeMinion = new Minion("Siege Minion", 805, 8, 40, 0, 0, 45, 92);
            siegeMinion.BlueImageURL = "https://vignette.wikia.nocookie.net/leagueoflegends/images/6/6c/Blue_Siege_MinionSquare.png/revision/latest/scale-to-width-down/48?cb=20140731204558";
            siegeMinion.RedImageURL = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c1/Red_Siege_MinionSquare.png/revision/latest/scale-to-width-down/48?cb=20140731204553";

            var superMinion = new Minion("Super Minion", 2000, 5, 190, 30, -30, 40, 97);
            superMinion.BlueImageURL = "https://vignette.wikia.nocookie.net/leagueoflegends/images/4/4a/Blue_Super_MinionSquare.png/revision/latest/scale-to-width-down/48?cb=20140731204557";
            superMinion.RedImageURL = "https://vignette.wikia.nocookie.net/leagueoflegends/images/0/04/Red_Super_MinionSquare.png/revision/latest/scale-to-width-down/48?cb=20140731204553";
            
            MinionList.Add(meleeMinion);
            MinionList.Add(casterMinion);
            MinionList.Add(siegeMinion);
            MinionList.Add(superMinion);

            return MinionList;
        }

        public List<Champion> LoadChampions()
        {
            var ChampionList = new List<Champion>();

            var Ahri = new Champion("Ahri", 526, 66, 53, 20, 30, 200, 1);
            Ahri.AbilityList.Add(new Ability("Orb of Deception", 65, Ability.Damage_Type.magic, 10));
            Ahri.AbilityList.Add(new Ability("Fox Fire", 50, Ability.Damage_Type.magic, 10));
            Ahri.AbilityList.Add(new Ability("Charm", 85, Ability.Damage_Type.magic, 20)); // stuns enemy allowing Ahri a 2nd attack
            Ahri.AbilityList.Add(new Ability("Spirit Rush", 100, Ability.Damage_Type.magic, 60));

            var Caitlyn = new Champion("Caitlyn", 475, 56, 62, 32, 30, 125, 2);
            Caitlyn.AbilityList.Add(new Ability("Piltover Peacemaker", 50, Ability.Damage_Type.physical, 8));
            Caitlyn.AbilityList.Add(new Ability("Yordle Snap Trap", 20, Ability.Damage_Type.physical, 8)); //chance to stun enemy based on opponent's attackSpeed
            Caitlyn.AbilityList.Add(new Ability("90 Caliber Net", 75, Ability.Damage_Type.magic, 15)); //reduces opponent's attackSpeed by 50% 
            Caitlyn.AbilityList.Add(new Ability("Ace in the Hole", 100, Ability.Damage_Type.physical, 60));

            var Darius = new Champion("Darius", 582, 62, 64, 39, 32, 85, 3);
            Darius.AbilityList.Add(new Ability("Decimate", 30, Ability.Damage_Type.physical, 6));
            Darius.AbilityList.Add(new Ability("Crippling Strike", 30, Ability.Damage_Type.physical, 12)); //Darius' next attack deals between 150%-200% damage
            Darius.AbilityList.Add(new Ability("Apprehend", 45, Ability.Damage_Type.physical, 15)); //reduces opponent's attackSpeed by 40% for one round 
            Darius.AbilityList.Add(new Ability("Noxian Guillotine", 100, Ability.Damage_Type.physical, 60));

            var Draven = new Champion("Draven", 200, 20, 30, 20, 15, 20, 4);
            Draven.AbilityList.Add(new Ability("Spinning Axe", 5, Ability.Damage_Type.physical, 6));
            Draven.AbilityList.Add(new Ability("Blood Rush", 8, Ability.Damage_Type.magic, 5)); //buff for bonus attack speed
            Draven.AbilityList.Add(new Ability("Stand Aside", 10, Ability.Damage_Type.physical, 12));
            Draven.AbilityList.Add(new Ability("Whirling Death", 15, Ability.Damage_Type.physical, 60));

            var Gragas = new Champion("Gragas", 583, 62, 61, 35, 32, 90, 5);
            Gragas.AbilityList.Add(new Ability("Barrel Roll", 60, Ability.Damage_Type.magic, 10));
            Gragas.AbilityList.Add(new Ability("Drunken Rage", 30, Ability.Damage_Type.magic, 10)); //buff for magic damage and reduce damage for 1 round
            Gragas.AbilityList.Add(new Ability("Body Slam", 50, Ability.Damage_Type.magic, 15));
            Gragas.AbilityList.Add(new Ability("Explosive Cask", 100, Ability.Damage_Type.magic, 60));

            var Lux = new Champion("Lux", 490, 62, 53, 18, 30, 180, 6);
            Lux.AbilityList.Add(new Ability("Light Binding", 50, Ability.Damage_Type.magic, 8));
            Lux.AbilityList.Add(new Ability("Prismatic Barrier", 60, Ability.Damage_Type.magic, 10)); //opponent magic attack reduce by 30% for 2 rounds
            Lux.AbilityList.Add(new Ability("Lucent Singularity", 70, Ability.Damage_Type.magic, 14)); //reduce opponent attackSpeed by 15% for 2 rounds
            Lux.AbilityList.Add(new Ability("Final Spark", 100, Ability.Damage_Type.magic, 60));

            var Malphite = new Champion("Malphite", 574, 63, 61, 37, 32, 90, 7);
            Malphite.AbilityList.Add(new Ability("Seismic Shard", 70, Ability.Damage_Type.magic, 8));
            Malphite.AbilityList.Add(new Ability("Brutal Strikes", 25, Ability.Damage_Type.physical, 12));
            Malphite.AbilityList.Add(new Ability("Ground Slam", 50, Ability.Damage_Type.magic, 14)); //reduce opponent attackSpeed by 15% for 1 round
            Malphite.AbilityList.Add(new Ability("Unstoppable Force", 100, Ability.Damage_Type.magic, 60));

            var Sona = new Champion("Sona", 100, 10, 10, 12, 20, 40, 8);
            Sona.AbilityList.Add(new Ability("Hymn of Valor", 3, Ability.Damage_Type.magic, 5));
            Sona.AbilityList.Add(new Ability("Aria of Perseverence", 5, Ability.Damage_Type.magic, 10));
            Sona.AbilityList.Add(new Ability("Song of Celerity", 8, Ability.Damage_Type.magic, 10));
            Sona.AbilityList.Add(new Ability("Crescendo", 15, Ability.Damage_Type.magic, 60));

            ChampionList.Add(Ahri);
            ChampionList.Add(Caitlyn);
            ChampionList.Add(Darius);
            ChampionList.Add(Draven);
            ChampionList.Add(Gragas);
            ChampionList.Add(Lux);
            ChampionList.Add(Malphite);
            ChampionList.Add(Sona);

            return ChampionList;
        }

        public bool MinionsAreRed()
        {
            var random = new Random();
            var randomNumber = random.Next(0, 2);
            if (randomNumber == 0)
                return true;
            else return false;
        }

        public int NumberOfMinionsInHorde()
        {
            var random = new Random();
            int numberOfMinions = random.Next(3, 7);
            return numberOfMinions;
        }

        public List<Minion> CreateHorde(int numberOfMinions)
        {
            var minionList = new List<Minion>();

            for (var i = 0; i < numberOfMinions; i++)
            {
                minionList.Add(RandomMinion(i));
            }

            return minionList;
        }

        public Minion RandomMinion(int id)
        {
            var minions = LoadMinions();
            var random = new Random();
            var index = random.Next(0, minions.Count);
            Minion randomMinion = minions[index];
            randomMinion.ID = id;
            return randomMinion;
        }
    }
}