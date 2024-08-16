using System;

namespace b3
{
    public class Key
    {   
        private static Key _instance;

        public static Key gI()
        {
            if (_instance == null) _instance = new Key();
            return _instance;
        }

        public int positionsX = 0;
        public int positionsY = 0;
        public void HandleKey()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow)
            {

            }
            if (key.Key == ConsoleKey.S || key.Key == ConsoleKey.DownArrow)
            {

            }
            if (key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.Spacebar)
            {

            }
        }
    }
}
