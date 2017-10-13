using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day5_Static
{
    class Cat
    {
        private int catCount;//tracks count
        

        public int CatCount
        {
            get { return this.catCount; }
            set { this.catCount = value; }
        }

        public Cat()
        {

        }

        //method
        public void WarCry()
        {
            Console.WriteLine("We are an army of " + catCount + " cats!!");
        }
    }
}
