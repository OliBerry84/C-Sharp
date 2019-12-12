using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary/multiple operators
            num3 = -num1;
            Console.WriteLine("num 3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++); // ++ after the operator increments it after this line of code. Post-increment
            Console.WriteLine("num is {0}", ++num); // ++ before the operator increments it as part of this line. Pre-increment

            //decrement operators
            num--;
            Console.WriteLine("num is {0}", num); 
            Console.WriteLine("num is {0}", num--); //post-decrement
            Console.WriteLine("num is {0}", --num); // pre-decrement


            // addition, subtraction, multiplication & division
            int result;

            result = num1 + num2; // 5, 3
            Console.WriteLine("The result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("The result of num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("The result of num1 divided by num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("The result of num1 multiplied num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("The result of num1 % num2 is {0}", result); // 5 divided by 3 = 1 with remainder of 2

            // relational and type operators
            bool isLower;
            bool isHigher;
            bool isEqual;

            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower); // num1 lower than num2?
            isHigher = num1 > num2;
            Console.WriteLine("result of num1 > num2 is {0}", isLower); // num1 lower than num2?
            isEqual = num1 == num2;
            Console.WriteLine("The result of num1 == num2 is {0}", isEqual); // 2 not equal to 5
            isEqual = num1 != num2;
            Console.WriteLine("The result of num1 != num2 is {0}", isEqual); // 2 not equal to 5 => true

            // conditional operators
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny); // both isLower and isSunny have to be true to make this return True value

            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny); // one OR the other need to be true to return a true value





            Console.Read();
        }
    }
}
