using System;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {   
            //declare 2d array
            string[,] matrix;
            

            // 3D array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,] 
            {
                { 1,2,3 },  //row0
                { 4,5,6 },  //row1 etc
                { 7,8,9 }
            };
            //Console.WriteLine("Central value is {0}", array2D[2,0]);
            //Console.ReadKey();

            string[,,] array3D = new string[,,]
            {
                {
                    { "000", "001"},
                    { "010", "011"},
                    { "Hi there", "What is up?"}
                },
                {
                    { "100", "101" },
                    { "102", "103" },
                    { "Another one", "Last Entry"}
                }
            };

            string[,] array2DString = new string[3, 2]
            {
                {"one", "two" },
                {"three", "four" },
                {"five", "six" }
            };

            array2DString[1, 1] = "chicken";

            //rank returns the dimensions of the array...2d or 3d etc.
            int dimensions = array2DString.Rank;

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } }; // another way of writing 2d array



            Console.WriteLine("The value is {0}", dimensions);
            Console.ReadKey();
        }
    }
}
