using System;

namespace _02.DefineConstructors
{
    class Display
    {
        public double Size { get; set; }

        public string NumberOfColors { get; set; }

        public Display()
        { 
        }

        public Display(double size, string colors)
        {
            this.Size = size;
            this.NumberOfColors = colors;
        }
    }
}