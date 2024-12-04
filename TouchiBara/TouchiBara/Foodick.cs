using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchiBara
{
    public class Foodick
    {
        public string name { get; set; }
        public int price { get; set; }
        public int qualities { get; set; }
        public int zapolnenost { get; }

        public Foodick(string Name,int Price,int Qualities,int Zapolnenost)
        { 
            name= Name;
            price= Price;
            qualities= Qualities;
            zapolnenost = Zapolnenost;
        }
        
    }
}
