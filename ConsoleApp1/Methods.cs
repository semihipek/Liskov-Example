using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        public string name { get; set; }
        public string position { get; set; }
    }

    public class BasketballPlayer : Player
    {
        public string team { get; set; }
    }
}
