using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeDayOne.Models;

namespace CodeDayOne.ViewModels
{
    public class BattleViewModel
    {
        public Party Party { get; set; }
        public Champion PartyMember1 { get; set; }
        public Champion PartyMember2 { get; set; }
        public List<Minion> BattleMinionList { get; set; }
        public List<Character> BattleOrder { get; set; }
        public bool IsRed { get; set; }

        public BattleViewModel()
        {
            BattleMinionList = new List<Minion>();
            BattleOrder = new List<Character>();
        }

        public List<Minion> CreateMinionHorde()
        {
            var minions = new List<Minion>();


            return minions;
        }
    }
}
