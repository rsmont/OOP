using System;

namespace _05.CapsulateWithProperties
{
    class Display
    {
        private double? size;

        public double? Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        private int? numColors;

        public int? NumberOfColors
        {
            get
            {
                return numColors;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Invalid value!");
                }
                else
                {
                    this.numColors = value;
                }
            }
        }

        public Display()
        {
            this.size = null;
            this.numColors = null;
        }

        public Display(double size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalid size value!");
            }
            else
            {
                this.size = size;
            }
            this.numColors = null;
        }

        public Display(double size, int colors)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalid size value!");
            }
            else
            {
                this.size = size;
            }
            if (colors < 1)
            {
                throw new ArgumentOutOfRangeException("Invalid colors value!");
            }
            else
            {
                this.numColors = colors;
            }
        }
    }
}