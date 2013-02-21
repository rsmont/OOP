using System;


namespace _01.DefineClass
{
    class GSM
    {
        public Display display = new Display();
        public Battery battery = new Battery();

        public string Model { get; set; }

        public double Price { get; set; }

        public string Owner { get; set; }

        public string Manifacturer { get; set; }
    }
}