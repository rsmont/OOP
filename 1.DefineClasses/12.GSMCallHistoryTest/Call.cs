using System;
using System.Linq;

namespace _12.GSMCallHistoryTest
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

        private string dialedPhone;

        public string DialedPhone
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

        public Call() : this("", "", "", 0)
        {

        }

        public Call(string date, string time, string dialedPhone, ulong duration)
        {
            this.date = date;
            this.time = time;
            this.dialedPhone = dialedPhone;
            this.duration = duration;
        }
    }
}