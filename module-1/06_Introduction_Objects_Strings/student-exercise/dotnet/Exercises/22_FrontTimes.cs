using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or
         whatever is there if the string is less than length 3. Return n copies of the front;
         FrontTimes("Chocolate", 2) → "ChoCho"
         FrontTimes("Chocolate", 3) → "ChoChoCho"
         FrontTimes("Abc", 3) → "AbcAbcAbc"
         */
        public string FrontTimes(string str, int n)
        {

            string longString = ""; // setting up the new string we will create with our copies
            string frontString = ""; // setting up a new string for the front three chars
            if (str.Length == 2) // if your length is 2, you need to return the first two chars on repeat
            {
                str = frontString = str.Substring(0, 2);
                for (int i = 0; i < n; i++) // using for loop to run through the value of n
                {
                    longString = longString + frontString; // adding another str each time
                }
            }
            return longString;


            if (str.Length == 1) // if your length is 1, you need to return the first char on repeat
            {
                str = frontString = str.Substring(0, 1);
                for (int i = 0; i < n; i++) // using for loop to run through the value of n
                {
                    longString = longString + frontString; // adding another str each time
                }
            }
            return longString;


            if (str.Length >= 3)

                for (int i = 0; i < n; i++) // using for loop to run through the value of n
                {
                    str = frontString = str.Substring(0, 3);
                    longString = longString + frontString; // adding another str each time
                }
            return longString;
        }

    }
}
