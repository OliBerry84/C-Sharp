using System;

namespace EnhancedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // condition? first_expression : second_expression
            // condition has to be either true or false
            // The conditional operator is right - associative
            // The expression a ? b: c? d : e
            // is evaluated as a ? b : (c ? d : e),
            // not as (a? b : c) ? d: e
            // The conditional operator cannot be overloaded.



            //in celcius + without curlys
            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
                stateOfMatter = "solid";
            else if (temperature > 100)
                stateOfMatter = "gas";
            else
                stateOfMatter = "liquid";

            Console.WriteLine("State of Matter is {0}", stateOfMatter);



            // shorter version
            temperature += 30; // to increase temperature to "liquid"
            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            // challenge - add gas state of matter to the options
            temperature += 100;
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of Matter is {0}", stateOfMatter);
            Console.ReadKey();
           
        }
    }
}
