using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b3
{
    internal class Player : Mob
    {
        
        private static Player gi;
        public Player(string name) 
        { 
            this.name = name;
        }
        public void showPlayer()
        {
            Console.SetCursorPosition(10, 10);
            Terminal.gI().print(representation,x,y,ConsoleColor.Green);
        }
    }
}
