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
            Player Quang = new Player("Phi cơ của Quang");
            Terminal.gI().setTitle("game LOR của cu Quang");
            Random TenBienRanDom = new Random();
            ConsoleKeyInfo key;
            new Thread(() =>
            {
                while (true)
                {
                    key = Console.ReadKey();
                    Terminal.gI().Move(Quang, key);
                }
            }).Start();
            new Thread(() =>
            {
                while (true)
                {
                    Quang.showPlayer();
                    Thread.Sleep(5);
                }
            }).Start();
        }
    }
}
