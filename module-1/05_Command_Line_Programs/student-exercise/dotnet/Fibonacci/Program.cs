using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 1;
            int next = 0;
            string fibText;
            int fibInput = 0;

            Console.WriteLine("Welcome to the Fibonacci generator!");

            Console.WriteLine("created by Leslie Wilson during Week 1 of TECBUS Cohort 12");

            Console.WriteLine();

            Console.WriteLine("Please neter the Fibonacci number:");
            fibText = Console.ReadLine(); //user inputs a number, read line must be a string
            fibInput = int.Parse(fibText); // turning the user input string into an integer
            Console.Write(first + " " + second + " ");

            while (next < fibInput) // starting my while loop
            {
                Console.Write(next + " ");

                next = first + second; //making the next number in the series the sum of my first and second variables
                
               
                    
                    first = second;
                    second = next;// cycling through the variables by setting them equal to the previous one.
               
            

            } // returning one value past my fibInput, need to break or stop cycle one round sooner.
            


                
        }
    }
}
