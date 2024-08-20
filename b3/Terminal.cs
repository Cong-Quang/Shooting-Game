using System;
using System.Threading;

namespace b3
{
    internal class Terminal
    {
        private static Terminal _instance;
        
        public static Terminal gI()
        {
            if (_instance == null) _instance = new Terminal();
            return _instance;
        }
        public int SizeX = 50;
        public int SizeY = 20;

        /// <summary>
        /// đặt title với hiệu ứng đánh chữ :> màu mè tí thôi
        /// </summary>
        /// <param name="s"></param>
        public void setTitle(string s)
        {
            new Thread(() =>
            {
                string sub = "";
                for (int i = 0; i < s.Length; i++)
                {
                    sub += s[i].ToString();
                    Console.Title = sub;
                    Thread.Sleep(100);
                }
            }).Start();
        }
        /// <summary>
        /// đặt lại kích thước cho cái console
        /// </summary>
        /// <param name="w"></param>
        /// <param name="h"></param>
        public void SetSizeTerminal(int w, int h)
        {
            if (w >= 1 && w <= Console.LargestWindowWidth && h >= 1 && h <= Console.LargestWindowHeight)
                Console.SetWindowSize(w, h);
            else throw new ArgumentOutOfRangeException("Kích thước vượt quá giới hạn cho phép.");
        }

        /// <summary>
        /// đặt chuỗi tại vị trí x,y màu mặc định là trắng
        /// và reset lại color sau khi thực hiện
        /// </summary>
        /// <param name="s"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="color"></param>
        public void print(string s, int x, int y, ConsoleColor color = ConsoleColor.White)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        public void PrintfBoard() 
        {
            print("-",0,0);
            print("-", 0, SizeY + 1);
            print("-", SizeX + 5, SizeY + 1);
            print("-", SizeX + 5, 0);

        }
        
        /// <summary>
        /// di chuyển theo mob
        /// </summary>
        /// <param name="mob"></param>
        public void Move(Mob mob, int key)
        {
            switch (key)
            {
                case 1:
                    MoveLeft(mob);
                    break;
                case 2:
                    MoveRight(mob);
                    break;
                case 3:
                    MoveUp(mob);
                    break;
                case 4:
                    MoveDown(mob);
                    break;
                //case ConsoleKey.Spacebar:
                //  //  Jump(mob);
                //    break;
            }
        }

        private void MoveLeft(Mob mob)
        {
            if (mob.x == 1)
                return;
            mob.x--;
            print(" ", mob.x + mob.representation.Length, mob.y);
        }

        private void MoveRight(Mob mob)
        {
            if (mob.x == SizeX - 1)
                return;
            mob.x++;
            print(" ", mob.x - 1, mob.y);
        }

        private void MoveUp(Mob mob)
        {
            if (mob.y == 1)
                return;
            mob.y--;
            int s = mob.y + 1;
            for (int i = 0; i < mob.representation.Length + 1; i++)
            {
                print(" ", mob.x + i, s);
            }
        }

        private void MoveDown(Mob mob)
        {
            if (mob.y == SizeY)
                return;
            mob.y++;
            int s = mob.y - 1;
            for (int i = 0; i < mob.representation.Length + 1; i++)
            {
                print(" ", mob.x + i, s);
            }
        }

        //private void Jump(Mob mob)
        //{
        //    for (int i = 1; i <= 4; i++)
        //    {
        //        MoveUp(mob);
        //        Thread.Sleep(5);
        //    }
        //    for (int i = 1; i <= 4; i++)
        //    {
        //        MoveDown(mob);
        //        Thread.Sleep(5);
        //    }
        //}
        //public Mob tele(Mob mob, ConsoleKeyInfo key)
        //{
        //    if (key.Key == ConsoleKey.A)
        //    {
        //        if ((mob.x - Player.representation.Length) < 0)
        //        {

        //        }
        //        else if (mob.x > 0 || mob.x < 10)
        //        {
        //            mob.x -= Player.representation.Length;
        //        }
        //    }
        //    if (key.Key == ConsoleKey.D)
        //    {
        //        if ((mob.x + Player.representation.Length) > 50)
        //        {

        //        }
        //        else if (mob.x > 0 || mob.x < 50)
        //        {
        //            mob.x += Player.representation.Length;
        //        }
        //    }

        //    if (key.Key == ConsoleKey.W)
        //    {
        //        if ((mob.y - Player.representation.Length) < 0)
        //        {

        //        }
        //        else if (mob.y > 0 || mob.y < 10)
        //        {
        //            mob.y -= Player.representation.Length;
        //        }
        //    }
        //    if (key.Key == ConsoleKey.S)
        //    {
        //        if ((mob.y + Player.representation.Length) > 30)
        //        {

        //        }
        //        else if (mob.y > 0 || mob.y < 30)
        //        {
        //            mob.y += Player.representation.Length;
        //        }
        //    }
        //    return mob;
        //}
    }
}