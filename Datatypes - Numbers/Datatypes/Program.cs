using System;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 69;
            int num3, num4, num5;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 + d2;
            double divD = d1 / num2;

            float f1 = 3.5f;

            num3 = 15;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sumD);
            Console.WriteLine(d1 + " divided by " + num2 + " is " + divD);

            Console.Read();
        }
    }
}
