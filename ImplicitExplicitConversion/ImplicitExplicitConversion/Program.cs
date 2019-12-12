using System;

namespace ImplicitExplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // IMPLICIT CONVERSION
            int num = 123456798;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;
                
            // EXPLICIT CONVERSION
            double myDouble = 13.37;
            int myInt;
            // cast double to int, integers can only have whole numbers
            myInt = (int)myDouble;

            // typeConversion - double to string etc.
            string myString = myDouble.ToString(); // 13.37 to "13.37"
            string floatString = myFloat.ToString();
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();


            Console.WriteLine(myBoolString);
            Console.Read();
        }
    }
}
