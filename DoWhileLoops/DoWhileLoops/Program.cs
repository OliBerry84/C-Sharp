using System;

namespace DoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 5);

            Console.WriteLine("-----------------------------");

            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfAFriend;
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks, that was enough! " + wholeText);

            Console.Read();

        
        }
    }
}
