using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColour;
        private int age;

        // default constructor
        public Human()
        {
            Console.WriteLine("Constructor called, Object created");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColour)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColour = eyeColour;
        }

        // parameterised constructor
        public Human(string firstName, string lastName, string eyeColour, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColour = eyeColour;
            this.age = age;
        }

        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        // public method
        public void IntroduceMyself()
        {
            if(age != 0 && lastName != null && eyeColour != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1}, I have {2} eyes and I am {3} years old!", firstName, lastName, eyeColour, age);
            else if(age != 0 && lastName != null && firstName != null) 
            { 
                Console.WriteLine("Hi, I'm {0} {1}, I am {2} years old", firstName, lastName, age); 
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, I'm {0}", firstName);
            }
        }
    }
}
