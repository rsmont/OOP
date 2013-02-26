using System;
using System.Linq;

namespace _08.CreateCallClass
{
    class Call
    {
        private DateTime date;

        public DateTime Date
        {
            get { return this.date; }
            set { date = value; }
        }

        private DateTime time;

        public DateTime Time
        {
            get { return this.time; }
            set { time = value; }
        }


        private uint dialedPhone;

        public uint DialedPhone
        {
            get { return dialedPhone; }
            set { dialedPhone = value; }
        }

        private uint duration;

        public uint Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        
        public Call(DateTime date, DateTime time, uint dialedPhone, ulong duration)
        {
            this.date = Date;
            this.time = Time;
            this.dialedPhone = DialedPhone;
            this.duration = Duration;
        
        }
    }
}
