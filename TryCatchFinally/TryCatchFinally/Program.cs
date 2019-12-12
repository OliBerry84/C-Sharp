using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception, please enter a correct type next time!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Too large or too small a number for an int32 format");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The input value was empty(null)");
            }
            catch (Exception)
            {
                Console.WriteLine("General Exception Error");
            }
            finally
            {
                Console.WriteLine("This is called anyway! Finally block is that after error, need to finish the code block! " +
                    "E.G. Tried to download from internet, if it worked or not need to close the connection to the internet. Finally would do that");
            }

            Console.ReadKey();
        }
    }
}
