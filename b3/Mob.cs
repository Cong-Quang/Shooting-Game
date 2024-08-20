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
        public string representation = "|(x)|";
        public string name { get; set; }
        public void attack(Mob mob)
        {
           this.hp -= mob.Dame;
        }
        public void healHP(float hp)
        {
            this.hp += hp;
        }
        public void healMana(float mana)
        {
            this.mana += mana;
        }
        
    }
}
