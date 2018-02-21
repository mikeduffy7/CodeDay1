using System;
namespace CodeDayOne.Models
{
    public class Ability
    {
        public string Name { get; set; }
        public int ManaCost { get; set; }
        public Damage_Type _DamageType { get; set; }
        public int CoolDown { get; set; }

        public Ability(string name, int manaCost, Damage_Type damageType, int coolDown)
        {
            this.Name = name;
            this.ManaCost = manaCost;
            this._DamageType = damageType;
            this.CoolDown = coolDown;
        }

        public enum Damage_Type
        {
            physical,
            magic
        }
    }
}
