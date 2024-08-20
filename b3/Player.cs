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
        public Player(string name, int x, int y) 
        { 
            this.name = name;
            this.x = x;
            this.y = y;
        }
        public void showPlayer()
        {
            Console.SetCursorPosition(10, 10);
            Terminal.gI().print(representation,x,y,ConsoleColor.Green);
        }
        public void showHP(int x, int y)
        {
            Terminal.gI().print($"                                 ", x, y, ConsoleColor.Red);
            Terminal.gI().print($"[{name}]:  {hp}%", x, y, ConsoleColor.Red);
        }
   
    }
}
