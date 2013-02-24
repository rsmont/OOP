using System;
using _01.DefineClass;


class MainClass
{
    static void Main(string[] args)
    {
        GSM gsm1 = new GSM();
        gsm1.Model = "nokia";
        gsm1.Price = 199.99;
        gsm1.Owner = "Pencho";
        gsm1.Manufacturer = "Nokia Corporation";
        gsm1.display.size = 4.5;
        gsm1.display.numberOfColors = "16M";
    }
}