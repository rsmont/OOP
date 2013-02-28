using System;
using System.Collections.Generic;
using System.Text;

namespace _12.GSMCallHistoryTest
{
    class GSM
    {
        private Display display = new Display();

        public Display Display
        {
            get
            {
                return display;
            }
            set
            {
                display = value;
            }
        }

        private Battery battery = new Battery("");

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public virtual void AddCallToHistory(string date, string time, string dialedPhone, ulong duration)
        {
            Call call = new Call(date, time, dialedPhone, duration);
            callHistory.Add(call);
        }

        public bool DeleteCallFromHistory(Call call)
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].Date == call.Date &&
                    callHistory[i].Time == call.Time &&
                    callHistory[i].DialedPhone == call.DialedPhone &&
                    callHistory[i].Duration == call.Duration)
                {
                    callHistory.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        private readonly List<Call> callHistory = new List<Call>();

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public void ClearHistory()
        {
            callHistory.Clear();
        }

        private decimal pricePerMinute;

        public decimal PricePerMinute
        {
            get
            {
                return pricePerMinute;
            }
            set
            {
                pricePerMinute = value;
            }
        }

        public decimal CalculatePrice()
        {

            decimal totalCalls = 0;
            foreach (var item in callHistory)
            {
                totalCalls += ((decimal)item.Duration/60);
            }
            return totalCalls * this.pricePerMinute;
        }

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

        private decimal? phoneprice;

        public decimal? PhonePrice
        {
            get
            {
                return phoneprice;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid Price!");
                }
                else
                {
                    this.phoneprice = value;
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

        private static readonly GSM iphone4S;

        public static GSM IPhone4S
        {
            get
            {
                return iphone4S;
            }
        }

        static GSM()
        {
            iphone4S = new GSM("4S", "Apple");
        }

        public GSM()
        { 
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.phoneprice = null;
            this.owner = null;
        }

        public GSM(string model, string manufacturer, decimal price) : this(model, manufacturer)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.phoneprice = price;
            }
            this.owner = null;
        }

        public GSM(string model, string manufacturer, decimal price, string owner) : this(model, manufacturer, price)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid value!");
            }
            else
            {
                this.phoneprice = price;
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
            str.Append("GSM Price: " + PhonePrice + " лв.");
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