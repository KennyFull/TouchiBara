using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchiBara
{
    public class Kapibara
    {
        private int Food { get; set; }
        private int pollution { get; set; }
        private int happiness { get; set; }
        private int money { get; set; }
        
        public Kapibara()
        {
            Food = 100;
            pollution = 100;
            happiness = 100;
            money = 0;
        }
        public Kapibara(int gold)
        {
            Food = 100;
            pollution = 100;
            happiness = 100;
            money = gold;
        }

        public int food()
        {
            return Food;
        }
        public int Pollution()
        {
            return pollution;
        }
        public int Happiness()
        {
            return happiness;
        }
        public int Money() { 
            return money;
        }
        public void SMoney(int gold)
        {
            money += gold;
        }
    }
}
