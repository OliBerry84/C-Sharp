using System;

namespace Constants
{
    // Constants are immutable values which are known
    // at compile time and do not change for the life of the program.
    class Program
    {

        // constants as fields

        const double PI = 3.14159265359;
        const int weeks = 52, month = 12;
        const string myBday = "21/03/1984";

        static void Main(string[] args)
        {
            // fields - Variables outside of any method
            Console.WriteLine("My birthday is always going to be: {0}", myBday);
            Console.Read();
        }
    }
}
