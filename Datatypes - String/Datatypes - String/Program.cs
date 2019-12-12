using System;

namespace Datatypes___String
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname = "Oli";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();
            string lowercaseMessage = message.ToLower();
            int msgMessage = message.Length;

            Console.WriteLine(message);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowercaseMessage);
            Console.WriteLine("There are " + msgMessage + " characters in this message");
            Console.Read();
        }
    }
}
