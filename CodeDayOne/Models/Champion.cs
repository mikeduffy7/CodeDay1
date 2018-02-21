using System;
using System.Collections.Generic;

namespace CodeDayOne.Models
{
    public class Champion : Character
    {
        public int Mana { get; set; }

        public Champion(string name, int health, int attackSpeed, int attack,
                         int defense, int armor, int magicResist, List<Ability> abilityList, int mana) 
            : base(name, health, attackSpeed, attack, defense, armor, magicResist, abilityList)
        {
            this.Mana = mana;
        }
    }
}
