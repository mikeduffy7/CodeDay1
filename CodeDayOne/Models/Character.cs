using System;
using System.Collections.Generic;

namespace CodeDayOne.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int AttackSpeed { get; set; }
        public int Attack { get; set; }
        public int Armor { get; set; }
        public int MagicResist { get; set; }
        public List<Ability> AbilityList { get; set; }

        public Character(string name, int maxHealth, int attackSpeed, int attack, 
                         int armor, int magicResist)
        {
            this.Name = name;
            this.MaxHealth = maxHealth;
            this.CurrentHealth = maxHealth;
            this.AttackSpeed = attackSpeed;
            this.Attack = attack;
            this.Armor = armor;
            this.MagicResist = magicResist;
            this.AbilityList = new List<Ability>();
        }
    }
}
