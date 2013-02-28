using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.GSMCallHistoryTest
{
    class GsmCallHistoryTest : GSM
    {
        public GsmCallHistoryTest()
        {
        }

        private uint testCount;

        public void AddSomeCalls(uint testCount)
        {
            this.testCount = testCount;
            Random rand = new Random();

            for (int i = 0; i < this.testCount; i++)
            {
                AddCallToHistory(DateTime.Now.ToShortDateString(),
                    DateTime.Now.ToShortTimeString(),
                    "08" + (rand.Next(11111111, 100000000).ToString()),
                    (ulong)rand.Next(10, 200));
            }
        }

        public void DeleteLongestCall()
        {
            ulong longestCallDuration = 0;
            Call longestCall = new Call();

            foreach (var item in this.CallHistory)
            {
                if (item.Duration >= longestCallDuration)
                {
                    longestCall = item;
                }
            }
            
            this.DeleteCallFromHistory(longestCall);
        }

        public override string ToString()
        {
            if (CallHistory.Count > 0)
            {
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < this.CallHistory.Count; i++)
                {
                    str.Append(Environment.NewLine);
                    str.Append("Date: " + this.CallHistory[i].Date);
                    str.Append(Environment.NewLine);
                    str.Append("Time: " + this.CallHistory[i].Time);
                    str.Append(Environment.NewLine);
                    str.Append("Tel. Number: " + this.CallHistory[i].DialedPhone);
                    str.Append(Environment.NewLine);
                    str.Append("Duration: " + this.CallHistory[i].Duration + " sec.");
                    str.Append(Environment.NewLine);
                }
                return str.ToString();
            }
            else
            {
                return ("History is empty !").ToString();
            }
        }
    }
}