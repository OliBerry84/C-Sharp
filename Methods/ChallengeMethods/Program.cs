using System;

namespace ChallengeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Nico";
            string friend2 = "Aaron";
            string friend3 = "Andrew";


            GreetFriend(friend1, friend2, friend3);
            Console.WriteLine(Greet("Oli"));
            Console.Read();
        }

        public static string Greet(string name)
        {
            return "Good morning " + name + ", I hope you are well";
        } 

        public static void GreetFriend(string friend1, string friend2, string friend3)
        {
            Console.WriteLine("Good morning " + friend1 + ", I hope all is well today!");
            Console.WriteLine("Good morning " + friend2 + ", I hope all is well today!");
            Console.WriteLine("Good morning " + friend3 + ", I hope all is well today!");
        }
    }
}
