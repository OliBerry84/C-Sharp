﻿using System;

namespace ParsingStringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            // must parse strings to integers to make the addition work
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;
            string result = myString + mySecondString; // concatenates the string

            Console.WriteLine(resultInt);
            Console.Read();
        }
    }
}
