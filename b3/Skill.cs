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
    }
}