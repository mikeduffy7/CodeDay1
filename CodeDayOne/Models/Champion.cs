using System;
using System.Collections.Generic;

namespace CodeDayOne.Models
{
    public class Champion : Character
    {
        public int Mana { get; set; }
        public string ImageSource { get; set; }

        public Champion(string name, int health, int attackSpeed, int attack,
                         int defense, int armor, int magicResist, List<Ability> abilityList, int mana) 
            : base(name, health, attackSpeed, attack, defense, armor, magicResist, abilityList)
        {
            this.Mana = mana;
            //ImageSource creates the URL to grab a champion's image from the LoL website
            this.ImageSource = "https://ddragon.leagueoflegends.com/cdn/8.3.1/img/champion/" + name + ".png";
        }
    }
}
