using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }



            string enteredText = "";
            int people = 0;

            while(enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase the amount by one and press anything else + enter if you want to finish counting.");
                enteredText = Console.ReadLine();

                people++;
                Console.WriteLine("Current people count is {0}", people);
            }

            Console.WriteLine("{0} people are inside the bus. Press enter to close the program", people);
            Console.Read();
        }
    }
}
