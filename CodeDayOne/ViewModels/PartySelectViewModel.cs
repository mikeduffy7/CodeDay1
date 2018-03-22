using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeDayOne.Models;

namespace CodeDayOne.ViewModels
{
    public class PartySelectViewModel
    {
        public Champion PartyMember1 { get; set; }
        public Champion PartyMember2 { get; set; }
        public List<Champion> Champions { get; set; }
    }
}
