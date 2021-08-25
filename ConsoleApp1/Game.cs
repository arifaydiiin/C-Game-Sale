using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        public string gamename { get; set; }
        public int gameprice { get; set; }
        public Game(string gamename, int gameprice)
        {
            gamename = gamename;
            gameprice = gameprice;
        }
    }
}
