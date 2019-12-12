using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human oli = new Human("Oli","Berry","blue", 35);
            oli.IntroduceMyself();

            Human sheila = new Human("Sheila","Gunson", "green", 65);
            sheila.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human jim = new Human("Jim", "Gunson", "green");
            jim.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human michael = new Human("Michael", "Miller");
            michael.IntroduceMyself();

            Human frank = new Human("Frank", "Miller", 25);
            frank.IntroduceMyself();

            Console.Read();
        }

        
    }
}
