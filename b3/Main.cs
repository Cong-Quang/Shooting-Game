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
            Player Quang = new Player("Phi cơ của Quang");
            Terminal.gI().setTitle("game LOR của cu Quang");

            while (true)
            {
                Quang.showPlayer();
                Quang.Move();
                Console.Clear();
                Thread.Sleep(1);
            }
        }
    }
}
