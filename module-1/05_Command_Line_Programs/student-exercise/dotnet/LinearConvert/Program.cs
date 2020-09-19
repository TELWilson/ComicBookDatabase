using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {

            // m = f * 0.3048
            // f = m * 3.2808399
            string LengthText;
            string mOrFText;
            double LengthNum = 0;
            double meters = 0;
            double feet = 0;

            Console.WriteLine("Metric Converter (feet/meters)");

            Console.WriteLine("written by Leslie Wilson during Week 1 of TECBUS Cohort-12");

            Console.WriteLine("Please enter the length:");
            LengthText = Console.ReadLine();
            LengthNum = double.Parse(LengthText);

            Console.WriteLine("Is the measurement in (m)eters, or (f)eet?");

            mOrFText = Console.ReadLine();

            meters = LengthNum * 3.280839;
            feet = LengthNum * 0.3048;

            if (mOrFText == "M" || mOrFText == "m")
            {
                Console.WriteLine(LengthNum + "m is " + meters + "f");
            }
            if (mOrFText == "F" || mOrFText == "f")
            {
                Console.WriteLine(LengthNum + "f is " + feet + "m");

            }


        }
    }
}
