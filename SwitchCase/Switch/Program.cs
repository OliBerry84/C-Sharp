using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 15;

            switch (age)
            {
                case 15:
                    Console.WriteLine("You're too young to get into the pub and get smashed");
                    break;
                case 25:
                    Console.WriteLine("Head away in and get twisted");
                    break;
                default:
                    Console.WriteLine("How old are you then if you are not 15 or 25?");
                    break;
            }

            // same thing but if statement

            if(age == 15)
            {
                Console.WriteLine("you're too young to get into the pub and get smashed");
            }else if(age == 25)
            {
                Console.WriteLine("Head away in and get twisted");
            } else
            {
                Console.WriteLine("How old are you then if you are not 15 or 25?");
            }

            // string switch statement
            string username = "Oli";

            switch (username)
            {
                case "Oli":
                    Console.WriteLine("Username is Oli");
                    break;
                case "Jimbob":
                    Console.WriteLine("Username is Jimbob");
                    break;
                default:
                    Console.WriteLine("Username is unknown");
                    break;
            }

            Console.Read();
        }
    }
}
