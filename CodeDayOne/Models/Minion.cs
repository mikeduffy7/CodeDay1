using System;
using System.Collections.Generic;
namespace CodeDayOne.Models
{
    public class Minion : Character
    {
        public int GoldGiven { get; set; }
        public int XPGiven { get; set; }
        public string BlueImageURL { get; set; }
        public string RedImageURL { get; set; }

        public Minion(string name, int maxHealth, int attackSpeed, int attack,
                      int defense, int armor, int magicResist, List<Ability> abilityList, int goldGiven, int xpGiven)
            :base(name, maxHealth, attackSpeed, attack, defense, armor, magicResist, abilityList)
        {
            this.GoldGiven = goldGiven;
            this.XPGiven = xpGiven;
        }
    }
}
