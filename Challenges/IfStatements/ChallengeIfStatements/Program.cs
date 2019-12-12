using System;

namespace ChallengeIfStatements
{
    class Program
    {

        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Your registration is complete");
            Console.WriteLine("-----------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if(username == Console.ReadLine())
            {
               if(password == Console.ReadLine())
                {
                    Console.WriteLine("You have successfully logged in");
                }
                else
                {
                    Console.WriteLine("Login has failed, incorrect password, please try again");
                }
            }
            else
            {
                Console.WriteLine("Login failed, incorrect username, please try again");
            }
        }
    }
}
