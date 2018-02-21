using System;
namespace CodeDayOne.Models
{
    public class Ability
    {
        public string Name { get; set; }
        public int ManaCost { get; set; }
        public DamageType DamageType { get; set; }
        public int CoolDown { get; set; }

        public Ability(string name, int manaCost, DamageType damageType, int coolDown)
        {
            this.Name = name;
            this.ManaCost = manaCost;
            this.DamageType = damageType;
            this.CoolDown = coolDown;
        }
    }

    var test = new Minion("test");
}
