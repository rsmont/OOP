﻿using System;
using _05.CapsulateWithProperties;


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

        gsm1.Owner = "Pencho";
        
        Console.WriteLine(gsm1);

    }
}