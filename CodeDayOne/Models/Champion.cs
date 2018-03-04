using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace CodeDayOne.Models
{
    public class Champion : Character
    {
        public int MaxMana { get; set; }
        public int CurrentMana { get; set; }
        public int XP { get; set; }
        public string ImageSource { get; set; }
        public SelectList AbilitySelectList { get; set; }

        public Champion(string name, int maxHealth, int attackSpeed, int attack,
                         int defense, int armor, int magicResist, List<Ability> abilityList, int maxMana) 
            : base(name, maxHealth, attackSpeed, attack, defense, armor, magicResist, abilityList)
        {
            this.MaxMana = maxMana;
            this.CurrentMana = maxMana;
            this.XP = 0;
            //ImageSource creates the URL to grab a champion's image from the LoL website
            this.ImageSource = "https://ddragon.leagueoflegends.com/cdn/8.3.1/img/champion/" + name + ".png";
        }
    }
}
