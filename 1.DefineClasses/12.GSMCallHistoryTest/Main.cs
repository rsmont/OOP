using System;
using _12.GSMCallHistoryTest;

class MainClass
{
    static void Main(string[] args)
    {
        GSM gsm1 = new GSM("Apple", "Apple Inc.");

        gsm1.PhonePrice = 1300;

        gsm1.Battery.HoursIdle = 120;
        gsm1.Battery.HoursTalk = 12;
        gsm1.Battery.TypeOfBattery = Battery.BatteryType.LiIon;  
        gsm1.Battery.Model = "China";
        gsm1.Display.NumberOfColors = 16;
        gsm1.Display.Size = 4.5;
        gsm1.Owner = "Pencho";
        Console.WriteLine(gsm1);


        GsmCallHistoryTest testPhone = new GsmCallHistoryTest();
        testPhone.AddSomeCalls(5);
        
        Console.WriteLine(testPhone);
        testPhone.PricePerMinute = 0.37m;
        
        Console.WriteLine("Price per minute: {0}", testPhone.PricePerMinute + " лв.");
        Console.WriteLine("Price for all phone calls in history: {0}", Math.Round(testPhone.CalculatePrice(), 3) + " лв.");
        testPhone.DeleteLongestCall();
        Console.WriteLine(testPhone);
        Console.WriteLine("Price for all phone calls in history: {0}", Math.Round(testPhone.CalculatePrice(), 3) + " лв.");
        testPhone.ClearHistory();
        Console.WriteLine("History is deleted !");
        Console.WriteLine(testPhone);

    }
}