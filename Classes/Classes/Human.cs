using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    // this class is a blueprint for a datatype
    class Human
    {
        // Member variable
        public string firstName;
        public string lastName;
        public string hobbies;

        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }

        public void Hobbies()
        {
            Console.WriteLine("I love {0}", hobbies);
        }
    }
}
