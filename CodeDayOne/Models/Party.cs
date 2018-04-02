using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeDayOne.Models
{
    public class Party
    {
        public int Gold { get; set; }
        public int XP { get; set; }

        public Party()
        {
            Gold = 0;
            XP = 0;
        }
    }
}
