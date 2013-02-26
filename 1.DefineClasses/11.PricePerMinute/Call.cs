using System;
using System.Linq;

namespace _11.PricePerMinute
{
    class Call
    {
        private string date;

        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                date = value;
            }
        }

        private string time;

        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                time = value;
            }
        }

        private uint dialedPhone;

        public uint DialedPhone
        {
            get
            {
                return dialedPhone;
            }
            set
            {
                dialedPhone = value;
            }
        }

        private ulong duration;

        public ulong Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }

        public Call() : this("", "", 0, 0)
        {

        }

        public Call(string date, string time, uint dialedPhone, ulong duration)
        {
            this.date = date;
            this.time = time;
            this.dialedPhone = dialedPhone;
            this.duration = duration;
        }
    }
}