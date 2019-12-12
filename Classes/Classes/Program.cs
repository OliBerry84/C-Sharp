using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object of my class
            // an instance of human
            Human oli = new Human();
            //can access public variable from outside and even change it
            oli.firstName = "Oliver";
            oli.lastName = "Berry";
            oli.hobbies = "my ps4";
            // call methods of the class (object oli)
            oli.IntroduceMyself();
            oli.Hobbies();

            Human nico = new Human();
            nico.firstName = "Nico";
            nico.lastName = "Utuk";
            nico.hobbies = "tinder";
            nico.IntroduceMyself();
            nico.Hobbies();

            Human andrew = new Human();         
            andrew.firstName = "Andrew";
            andrew.lastName = "Anderson";
            andrew.hobbies = "lamp";
            andrew.IntroduceMyself();
            andrew.Hobbies();

            Console.ReadKey();
        }
    }
}
