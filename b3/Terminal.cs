using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace b3
{
    public class Terminal
    {
        private static Terminal gi;
        public static Terminal gI() 
        {
            if (gi == null) gi = new Terminal();
            return gi;
        }
        public Terminal()
        {
           
            Data.TitleMap = "MOB ĐẶT BIỆT";
        }
        public void test()
        {
            foreach (char x in "MOB ĐẶT BIỆT")
            {
                Console.Title = x.ToString();
                Thread.Sleep(20);
            }
        }
    }
}
