using System;
using _03.AddEnumeration;


class MainClass
{
    static void Main(string[] args)
    {
        GSM gsm1 = new GSM("nokia", "nokia Corp");
        gsm1.Battery.HoursIdle = 120;
        gsm1.Battery.HoursTalk = 12;
        gsm1.Display.NumberOfColors = "16m";
        gsm1.Display.Size = 4.5;
        gsm1.Owner = "Pencho";
        gsm1.Price = 1300;
        gsm1.TypeOfBattery = Battery.BatteryType.NiCd;
    }
}