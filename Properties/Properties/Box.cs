using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Box
    {
        // member variables - on level of the class Box. Direct impact on structure of Box
        private int length = 3;
        public int height;
        public int width;
        public int volume;

        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.length * this.height * this.width;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, Height is {1} and the Width is {2}. Therefore the volume is {3}", length, height, width, volume = length*height*width);
        }


    }
}
