using System;
using System.Text;

namespace _04.OverrideToString
{
    class GSM
    {
        public Display Display = new Display();
        public Battery Battery = new Battery("");
        public Battery.BatteryType TypeOfBattery;
        private decimal? price;
        private string owner;

        public string Model { get ; set; }

        public decimal? Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid Price!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public string Manufacturer { get; set; }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
        }

        public GSM(string model, string manufacturer, decimal price) : this(model, manufacturer)
        {
            if (Price < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.price = Price;
            }
            this.owner = null;
        }

        public GSM(string model, string manufacturer, decimal price, string owner) : this(model, manufacturer, price)
        {
            if (Price < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.price = Price;
            }
            this.owner = Owner;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("GSM Model: " + Model);
            str.Append(Environment.NewLine);
            str.Append("GSM Manufacturer: " + Manufacturer);
            str.Append(Environment.NewLine);
            str.Append("GSM Price: " + Price + " лв.");
            str.Append(Environment.NewLine);
            str.Append(Environment.NewLine);
            str.Append("Battery Model: " + Battery.Model);
            str.Append(Environment.NewLine);
            str.Append("Battery Type: " + Battery.TypeOfBattery);
            str.Append(Environment.NewLine);
            str.Append("Battery Idle Time: " + Battery.HoursIdle + " hours");
            str.Append(Environment.NewLine);
            str.Append("Battery Talk Hours: " + Battery.HoursTalk + " hours");
            str.Append(Environment.NewLine);
            str.Append(Environment.NewLine);
            str.Append("Display Size: " + Display.Size + "\"");
            str.Append(Environment.NewLine);
            str.Append("Display Colors: " + Display.NumberOfColors);
            str.Append(Environment.NewLine);
            str.Append("GSM Owner: " + Owner);
            str.Append(Environment.NewLine);
            return str.ToString();
        }
    }
}