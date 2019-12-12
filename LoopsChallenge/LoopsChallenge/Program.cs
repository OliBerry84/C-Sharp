﻿using System;

namespace LoopsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while(input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter -1 once you have entered all of the scores");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("----------------------------------------");
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average score of your studens is {0}", average);
                }
                if (int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total = total + currentNumber;
                } 
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 & 20!");
                    }
                    continue;
                }

                count++;

            }

            Console.Read();
        }
    }
}
