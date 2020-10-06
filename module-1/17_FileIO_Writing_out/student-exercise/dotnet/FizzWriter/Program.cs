using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fizzyString = GetReadmeDir();
            string output = Path.Combine(fizzyString, "FizzBuzz.txt");

            bool shouldAppend = false;
            using (StreamWriter writer = new StreamWriter(output, shouldAppend))
            {
                for (int input = 1; input <= 300; input++)
                {

                    if (input % 3 == 0 && input % 5 == 0)
                    {
                        writer.WriteLine("FizzBuzz");
                    }
                    if (input % 5 == 0)
                    {
                        writer.WriteLine("Buzz");
                    }
                    if (input % 3 == 0)
                    {
                        writer.WriteLine("Fizz");
                    }
                    writer.WriteLine(input);
                }

            }


        }


        /// <summary>
        /// Gets the full path to the directory with the readme file
        /// </summary>
        /// <returns>The full path to the directory with the readme file</returns>
        public static string GetReadmeDir()
        {
            string dir = Environment.CurrentDirectory;

            System.IO.DirectoryInfo netcoreappDir = System.IO.Directory.GetParent(dir);
            System.IO.DirectoryInfo binDir = System.IO.Directory.GetParent(netcoreappDir.FullName);
            System.IO.DirectoryInfo codeDir = System.IO.Directory.GetParent(binDir.FullName);
            System.IO.DirectoryInfo readmeDir = System.IO.Directory.GetParent(codeDir.FullName);

            return readmeDir.FullName;
        }
    }
    //public string FizzBuzz(int input)
    //{
    //    string check = input.ToString();
    //    //Need to cycle through ints 1-300 and plus one input each time
    //    //Need to create if statements to check for conditions of divisible by 3, 5, and 3&5

    //    if (input >= 1 && input <= 300)
    //    {
    //        if (input % 3 == 0 && input % 5 == 0)
    //        {
    //            return "FizzBuzz";
    //        }
    //        if(input % 5 == 0)
    //        {
    //            return "Buzz";
    //        }
    //        if(input % 3 == 0)
    //        {
    //            return "Fizz";
    //        }
    //        return input.ToString();
    //    }
    //    return " ";
    //}
}
