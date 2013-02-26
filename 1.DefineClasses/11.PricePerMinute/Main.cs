using System;
using _11.PricePerMinute;


class MainClass
{
    static void Main(string[] args)
    {
        GSM gsm1 = new GSM("Nokia", "Nokia Corp");

        gsm1.Price = 1300;

        gsm1.Battery.HoursIdle = 120;
        gsm1.Battery.HoursTalk = 12;
        gsm1.TypeOfBattery = Battery.BatteryType.NiCd;  
        gsm1.Battery.Model = "China";
        gsm1.Display.NumberOfColors = 16;
        gsm1.Display.Size = 4.5;
        Call call = new Call("26.2.2013", "12:00", 0887698631, 123);
        gsm1.AddCallToHistory(call);
        gsm1.Owner = "Pencho";
        
        Console.WriteLine(gsm1);

        Console.WriteLine(gsm1.CallPrice(0.45m));

        
        //GSM gsm2 = GSM.IPhone4S;
        //Console.WriteLine(gsm2);

        //GSMTest gsm3 = new GSMTest(5);
        //foreach (var item in gsm3)
        //{
        //    Console.WriteLine(item);    
        //}
        
    }
}