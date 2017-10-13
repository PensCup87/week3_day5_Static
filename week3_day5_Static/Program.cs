using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day5_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //we can create a collection of objects
            List<Cat> catArmy = new List<Cat>();
            List<Turtle> turtleArmy = new List<Turtle>();

            Random rand = new Random();

            //lets create the armies

            for(int i = 0; i < 100; i++)
            {
                if(rand.NextDouble() >= 0.5)//if rand is more than .5 add a cat to the cat army Else add a turtule to turtle Army
                {
                    catArmy.Add(new Cat());
                }
                else
                {
                    turtleArmy.Add(new Turtle());
                }
            }


            //Code to tell each cat how many cats there are
            //We'll need to run this code any time there is a new cat added

            int totalCats = catArmy.Count;

            foreach(Cat cat in catArmy)
            {
                cat.CatCount = totalCats;
            }

            catArmy[0].WarCry();

            //code to tell each turtle how many turutles there are
            //only 1 line of Code for turtle because Turtle Was STATIC
            Turtle.WarCry();
        }
    }
}
