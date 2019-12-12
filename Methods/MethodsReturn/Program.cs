using System;

namespace MethodsReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = Add(13, 15);
            //Console.WriteLine(result);
            //Console.Read();

            Console.WriteLine(Add(Add(1,2),Add(3,4)));
            Console.WriteLine(Add(15,13));

            Console.WriteLine(Multiply(5, 4));
            Console.WriteLine(Multiply(Multiply(1,2), Multiply(3,4)));

            Console.WriteLine(Divide(25,13));

            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
