using System;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            //int temperature = 25;

            //if(temperature < 10)
            //{
            //    Console.WriteLine("Take a coat with you, it's less than 10 degrees");
            //}

            //if(temperature == 10)
            //{
            //    Console.WriteLine("It's 10 degress celsius");
            //}

            //if(temperature > 10)
            //{
            //    Console.WriteLine("It's warm enough, don't need your jacket!");
            //}

            Console.WriteLine("What temparture is it outside??");
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

            if (numTemp < 20)
            {
                Console.WriteLine("Take a coat with you, it's less than 10 degrees");
            }

            if (numTemp == 20)
            {
                Console.WriteLine("It's 20 degress celsius, Trousers and a jumper will do you fine");
            }

            if (numTemp > 20)
            {
                Console.WriteLine("It's warm enough, get your willy out");
            }

            Console.Read();
        }
    }
}
