using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day5_Static
{
    class Turtle
    {
        //This static variable belongs to the CLASS and is shared amoung all instances
        //every object will have the same value
        //This also means you can use the variable Without Creating an instance first

        static int turtleCount;
        //static Does Not Need a Property


        public Turtle()
        {
            turtleCount++;//ever instance makes an additional turtle
        }

        //The static method belongs to the class
        //Its shared amoung all instances
        //We can use the method without creating a first instance - can just call the method
        public static void WarCry()
        {
            Console.WriteLine("We are an army of " + turtleCount + " turtles1");
        }
    }
}
