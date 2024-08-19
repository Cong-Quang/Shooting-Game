using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b3
{
    internal class Mob
    {
        public int x { get; set; }
        public int y { get; set; }
        public float hp = 100f;
        public float mana = 0;
        public float Dame = 10f;
        public char MoveH;
        public string name { get; set; }
        public void attack(Mob mob)
        {
            mob.Dame -= this.Dame;
        }
        public void healHP(float hp)
        {
            this.hp += hp;
        }
        public void healMana(float mana)
        {
            this.mana += mana;
        }
        public void Move()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.LeftArrow)
            {
                if (x == 0)
                    return;
                x--;
            }
            if (key.Key == ConsoleKey.RightArrow)
            {
                if (x == 50)
                    return;
                x++;
            }
            if (key.Key == ConsoleKey.UpArrow)
            {
                if (y == 0)
                    return;
                y--;
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                if (y == 20)
                    return;
                y++;
            }
            Skill.gI().tele(this,key);
        }
    }
}
