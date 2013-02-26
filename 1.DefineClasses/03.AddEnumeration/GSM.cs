using System;

namespace _03.AddEnumeration
{
    class GSM
    {
        public Display Display = new Display();
        public Battery Battery = new Battery("");
        public Battery.BatteryType TypeOfBattery;

        public string Model { get; set; }

        public decimal Price { get; set; }

        public string Owner { get; set; }

        public string Manufacturer { get; set; }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            Price = 0.0m;
            Owner = null;
        }

        public GSM(string model, string manufacturer, decimal price) : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner) : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }
    }
}