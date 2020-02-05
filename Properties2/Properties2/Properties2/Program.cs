using System;

namespace Properties2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Box box = new Box();
            //box.length = 3;
            //box.SetLength(4);
            //box.Height = -4;
            //box.Width = 5;
            //Console.WriteLine("boxes width is " + box.Width);
            //Console.WriteLine("Boxes volume is " + box.Volume);
            //box.DisplayInfo();
            Box box = new Box(3, 4, 5);
            Console.WriteLine("boxes width is " + box.Width);
            box.Width = 10;
            Console.WriteLine("Boxes volume is " + box.Volume);
            box.DisplayInfo();
        } 
    }
}
