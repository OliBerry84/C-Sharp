 using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temparature outside?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;

            if(int.TryParse(temperature, out number))
            {
                numTemp = number;
            }else
            {
                numTemp = 0;
                Console.WriteLine("Value entered was not a number, 0 set as temperature by default");
            }

            if(numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }else if(numTemp == 20)
            {
                Console.WriteLine("Pants and jacket be grand");
            }else if(numTemp == 30)
            {
                Console.WriteLine("weeeeeeeeee, grab an ice cream or a beer and get skin cancer");
            }else
            {
                Console.WriteLine("It's fine, no need for a jacket");
            }

            Console.Read();
        }
    }
}
