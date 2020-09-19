using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tf = Tc * 1.8 + 32
            // Tc = (Tf-32) / 1.8
            double tempNum = 0;
            //double temp = 0;
            double tempF = 0;
            double tempC = 0;
            string tempText;
            string fahrOrCelText;

            Console.WriteLine("Welcome to the temperature converter!");
            Console.WriteLine();
            Console.WriteLine("Written by Leslie Wilson on 9/18.2020");
            Console.WriteLine();
            Console.WriteLine("Please enter the the temperature:");
           
            tempText = Console.ReadLine();
            tempNum = double.Parse(tempText);

            Console.WriteLine("Is the temperature in (C)elsius, or (F)ahrenheit?");

            fahrOrCelText = Console.ReadLine();

            tempC = tempNum * 1.8 + 32;
            tempF = (tempNum - 32) / 1.8;

            if (fahrOrCelText == "C" || fahrOrCelText == "c")
            {
                Console.WriteLine(tempNum + "C is " + tempC + "F");
            }
            if (fahrOrCelText == "F" || fahrOrCelText == "f")
            {
                Console.WriteLine(tempNum + "F is " + tempF + "C");
            }



        }
    }
}
