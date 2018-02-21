using System;
using System.Collections.Generic;
namespace CodeDayOne.Models
{
    public class Minion : Character
    {
        public Minion(string name, int health, int attackSpeed, int attack,
                      int defense, int armor, int magicResist, List<Ability> abilityList)
            :base(name, health, attackSpeed, attack, defense, armor, magicResist, abilityList)
        {
        }
    }
}
