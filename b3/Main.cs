using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace b3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;

            GameLoop();
        }
        static void GameLoop()
        {
            Player Quang = new Player("Phi cơ của Quang", Terminal.gI().SizeX / 2,Terminal.gI().SizeY - 3);
            mob1 mob1 = new mob1(2,20,10);
            Terminal.gI().setTitle("game LOR của cu Quang");
            Terminal.gI().PrintfBoard();
            ConsoleKeyInfo key;
            new Thread(() =>
            {
                while (true)
                {
                    key = Console.ReadKey();
                    int keyx = 0;
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            keyx = 1;
                            break;
                        case ConsoleKey.RightArrow:
                            keyx = 2;
                            break;
                        case ConsoleKey.UpArrow:
                            keyx = 3;
                            break;
                        case ConsoleKey.DownArrow:
                            keyx = 4;
                            break;
                        case ConsoleKey.Enter:
                          //  Quang.hp -= mob1.Dame;
                            Quang.healHP(mob1.Dame);
                            break;
                    }
                    Terminal.gI().Move(Quang, keyx);
                    mob1.AutoHit(Quang);
                    Thread.Sleep(5);
                }
            }).Start();
            new Thread(() =>
            {
                while (true)
                {
                    Quang.showPlayer();
                    mob1.showMob();
                    mob1.showPlayer();
                    
                    if (Quang.x == mob1.x && Quang.y == mob1.y )
                    {
                        Quang.attack(mob1);
                    }
                    Quang.showHP(0, Terminal.gI().SizeY + 3);
                    Thread.Sleep(10);
                }
            }).Start();
        }
    }
}
