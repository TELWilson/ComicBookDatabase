using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string FizzBuzz(int input)
        {
            //string three = input.ToString().Contains("3")

            if (input >= 1 && input <= 100)
            {
                if (input % 3 == 0 && input % 5 == 0)
                {
                    return "FizzBuzz";
                }
                if (input % 3 == 0 || input.ToString().Contains("3")) 
                {
                    return "Fizz";
                }
                else if (input % 5 == 0)
                {
                    return "Buzz";
                }
                return input.ToString();
            }
            return " ";
        }
    }
}
