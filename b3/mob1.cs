using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b3
{
    internal class mob1 : Mob
    {
        public mob1(int dame, int x, int y)
        {
            this.Dame = dame;
            this.x = x;
            this.y = y;
        }
        public void AutoHit(Mob player)// bắn đạn xuống
        {
            this.x = 1;
            this.y = 1;
            if (player.y == y) 
            {
                this.x = player.x;
                for (int i = 0; i < player.y  ; i++)
                {
                    Terminal.gI().Move(this, 4);

                }
            }
        }
        public void showPlayer()
        {
            Console.SetCursorPosition(10, 10);
            Terminal.gI().print(representation, x, y, ConsoleColor.Green);
        }
        public void showMob()
        {
            Terminal.gI().print($"{hp}][{Dame}",0, Terminal.gI().SizeY + 4);
        }
    }
}
