using System;

namespace _03.AddEnumeration
{
    class Battery
    {
        public string Model { get; set; }

        public int HoursIdle { get; set; }

        public int HoursTalk { get; set; }

        private BatteryType result;

        public BatteryType TypeOfBattery
        {
            get { return result; }
            
        }
        

        public Battery(string model)
        {
            this.Model = model;
            this.HoursIdle = 0;
            this.HoursTalk = 0;
        }

        public Battery(string model, int hoursIdle, int hoursTalk) : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public enum BatteryType
        { 
            LiIon,
            NiMH,
            NiCd,
        }
    }
}