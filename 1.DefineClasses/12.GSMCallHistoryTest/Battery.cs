using System;

namespace _12.GSMCallHistoryTest
{
    class Battery
    {
        private int? hoursIdle;

        public int? HoursIdle
        {
            get
            {
                return hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid hoursIdle value!");
                }
                else
                {
                    hoursIdle = value;
                }
            }
        }

        private int? hoursTalk;

        public int? HoursTalk
        {
            get
            {
                return hoursTalk;
            }
            set

            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid hoursTalk value!");
                }
                else
                {
                    hoursTalk = value;
                }
            }
        }

        public enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd,
        }

        private BatteryType typeOfBattery;

        public BatteryType TypeOfBattery
        {
            get
            {
                return this.typeOfBattery;
            }
            set
            {
                this.typeOfBattery = value;
            }

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

        public Battery(string model)
        {
            this.model = model;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }

        public Battery(string model, int hoursIdle) : this(model)
        {
            if (hoursIdle < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid hoursIdle value!");
            }
            else
            {
                this.hoursIdle = hoursIdle;
            }
            this.hoursTalk = null;
        }

        public Battery(string model, int hoursIdle, int hoursTalk) : this(model)
        {
            if (hoursIdle < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid hoursIdle value!");
            }
            else
            {
                this.hoursIdle = hoursIdle;
            }
            if (hoursTalk < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid hoursTalk value!");
            }
            else
            {
                this.hoursTalk = hoursTalk;
            }
        }

        
    }
}