using System;
using System.Collections;
using System.Collections.Generic;

namespace _11.PricePerMinute
{
    class GSMTest : GSM, IEnumerable, IEnumerator
    {
        GSM[] testPhone;

        public GSMTest(uint numbers)
        {
            testPhone = new GSM[numbers];

            for (int i = 0; i < testPhone.Length; i++)
            {
                this.testPhone[i] = new GSM("Model " + (i + 1), "Manufacturer " + (i + 1), 500 + i * 10, "Owner " + (i + 1));
                this.testPhone[i].Battery = new Battery("Model " + (i + 1), 100 + i, 10 + i);
                this.testPhone[i].Display = new Display(i + 1, 5 + i);
            }
        }

        private int position = -1;

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        
        public object Current
        {
            get
            {
                return testPhone[position];
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < testPhone.Length);
        }

        public void Reset()
        {
            position = 0;
        }
    }
}