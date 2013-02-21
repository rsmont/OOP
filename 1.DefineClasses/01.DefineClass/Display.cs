using System;

namespace _01.DefineClass
{
    class Display
    {
        public double size { get; set; }

        public int numberOfColors { get; set; }

        public Display()
        {
            this.size = 4;
            this.numberOfColors = 65535;
        }
    }
}