using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int counter = 0; counter < 50; counter+=5)
            {
                Console.WriteLine(counter + " is lower than 50");
            }
            Console.WriteLine("For loop has finished");
            Console.WriteLine("---------------------");

            for (int odd = 1; odd < 20; odd += 2)
            {
                Console.WriteLine(odd);
            }
            Console.WriteLine("The numbers above are the odd numbers between 0 & 20");
            Console.Read();
        }
    }
}
