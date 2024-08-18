namespace b3
{
    internal class Skill
    {
        private string Tele = "Dịch chuyển tức thời";
        private string Kame = "Trưởng";

        public void Stele(Mob mob)
        {
            if (mob.MoveH == 't') // trái
            {
                if (mob.y == Terminal.gI().minSize + 2) return;
                mob.y -= 10;
                mob.mana -= 25;
            }
            if (mob.MoveH == 'p') // phải
            {
                if (mob.y == Terminal.gI().maxSize - 2) return;
                mob.y += 10;
                mob.mana -= 25;
            }
        }
    }
}
