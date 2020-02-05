﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Properties2
{
    class Box
    {
        // member variable
        private int length = 3;
        private int height;
        //public int width;
        private int volume;

        public int Width { get; set; }

        //public int volume { get; set; }
        
        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if(value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
                
            }
        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.Width = width;
        }

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
            return this.length * this.height * this.Width;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1}, width is {2} so the volume is {3}", length, height, Width, volume = length*height*Width);
        }
    }
}
