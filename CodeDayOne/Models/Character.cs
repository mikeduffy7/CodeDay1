﻿using System;
using System.Collections.Generic;

namespace CodeDayOne.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackSpeed { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Armor { get; set; }
        public int MagicResist { get; set; }
        public List<Ability> AbilityList { get; set; }

        public Character(string name, int health, int attackSpeed, int attack, 
                         int defense, int armor, int magicResist, List<Ability> abilityList)
        {
            Name = name;
            Health = health;
            AttackSpeed = attackSpeed;
            Attack = attack;
            Defense = defense;
            Armor = armor;
            MagicResist = magicResist;
            AbilityList = abilityList;
        }
    }
}
