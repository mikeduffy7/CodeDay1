using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeDayOne.Models
{
    public class Game
    {
        public List<Champion> ChampionList { get; set; }

        public Game()
        {
            ChampionList = new List<Champion>();
        }

        public List<Champion> LoadChampions()
        {
            var Sona = new Champion("Sona", 100, 10, 10, 15, 12, 20, new List<Ability>(), 40);
            Sona.AbilityList.Add(new Ability("Hymn of Valor", 3, Ability.Damage_Type.magic, 5));
            Sona.AbilityList.Add(new Ability("Aria of Perseverence", 5, Ability.Damage_Type.magic, 10));
            Sona.AbilityList.Add(new Ability("Song of Celerity", 8, Ability.Damage_Type.magic, 10));
            Sona.AbilityList.Add(new Ability("Crescendo", 15, Ability.Damage_Type.magic, 30));

            var Draven = new Champion("Draven", 200, 20, 30, 20, 20, 15, new List<Ability>(), 20);
            Draven.AbilityList.Add(new Ability("Spinning Axe", 5, Ability.Damage_Type.physical, 6));
            Draven.AbilityList.Add(new Ability("Blood Rush", 8, Ability.Damage_Type.magic, 5)); //buff for bonus attack speed
            Draven.AbilityList.Add(new Ability("Stand Aside", 10, Ability.Damage_Type.physical, 12));
            Draven.AbilityList.Add(new Ability("Whirling Death", 15, Ability.Damage_Type.physical, 35));

            ChampionList.Add(Sona);
            ChampionList.Add(Draven);

            return ChampionList;
        }
    }
}
