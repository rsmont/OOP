using System;

namespace _08.CreateCallClass
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

        public Display() : this(null, null)
        {
        }

        public Display(double size) : this(size, null)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalid size value!");
            }
            else
            {
                this.size = size;
            }
        }

        public Display(double? size, int? colors)
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