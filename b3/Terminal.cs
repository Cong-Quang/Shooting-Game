using System;
using System.Threading;

namespace b3
{
    internal class Terminal
    {
        private static Terminal _instance;
        public int maxSize = 0;
        public int minSize = 0;
        public static Terminal gI()
        {
            if (_instance == null) _instance = new Terminal();
            return _instance;
        }

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
                    Thread.Sleep(120);
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
    }
}
