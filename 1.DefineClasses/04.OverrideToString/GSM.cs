﻿using System;
using System.Text;

namespace _04.OverrideToString
{
    class GSM
    {
        public Display Display = new Display();
        public Battery Battery = new Battery("");
        public Battery.BatteryType TypeOfBattery;

        private string model;

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        private decimal? price;

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

        private string owner;

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

        private string manufacturer;

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }

        public GSM(string model, string manufacturer) : this(model, manufacturer, null, null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal? price) : this(model, manufacturer, price, null)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.price = price;
            }
        }

        public GSM(string model, string manufacturer, decimal? price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.price = price;
            }
            this.owner = owner;
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
            str.Append("Display Colors: " + Display.NumberOfColors + "M");
            str.Append(Environment.NewLine);
            str.Append("GSM Owner: " + Owner);
            str.Append(Environment.NewLine);
            return str.ToString();
        }
    }
}