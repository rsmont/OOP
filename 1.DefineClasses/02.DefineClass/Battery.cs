using System;

namespace _02.DefineConstructors
{
    class Battery
    {
        public string Model { get; set; }

        public int HoursIdle { get; set; }

        public int HoursTalk { get; set; }

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
    }
}