using System;

namespace b3
{
    internal class Skill
    {
        private static Skill gi;
        private string Tele = "Dịch chuyển tức thời";
        private string Kame = "Trưởng";
        public static Skill gI()
        {
            if (gi == null)  gi = new Skill(); 
            return gi;
        }
        public Mob tele(Mob mob, ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.A)
            {
                if ((mob.x - Player.representation.Length) < 0)
                {

                }
                else if (mob.x > 0 || mob.x < 10)
                {
                    mob.x -= Player.representation.Length;
                }
            }
            if (key.Key == ConsoleKey.D)
            {
                if ((mob.x + Player.representation.Length) > 50)
                {

                }
                else if (mob.x > 0 || mob.x < 50)
                {
                    mob.x += Player.representation.Length;
                }
            }

            if (key.Key == ConsoleKey.W)
            {
                if ((mob.y- Player.representation.Length) < 0)
                {

                }
                else if (mob.y> 0 || mob.y < 10)
                {
                    mob.y -= Player.representation.Length;
                }
            }
            if (key.Key == ConsoleKey.S)
            {
                if ((mob.y + Player.representation.Length) > 30)
                {

                }
                else if (mob.y > 0 || mob.y < 30)
                {
                    mob.y += Player.representation.Length;
                }
            }
            return mob;
        }
    }
}
