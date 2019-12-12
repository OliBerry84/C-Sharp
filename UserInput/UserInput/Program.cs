using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine(); // prompt user to write something to read it later on, stored in a string called input
            //Console.WriteLine(input);
            //Console.Read();
            Calculate();
            Console.Read();
        }

        public static void Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;

            Console.WriteLine(result);
        }
    }
}
