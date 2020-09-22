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
         Given a string, return a "rotated left 2" version where the first 2 chars are moved to the end.
         The string length will be at least 2.
         Left2("Hello") → "lloHe"
         Left2("java") → "vaja"
         Left2("Hi") → "Hi"
         */
        public string Left2(string str)
        { //need to make two new strings that are substrings of the original
            int strLength = str.Length-2; //finding the length value for the substring for the new remainString
            string firstTwo = str.Substring(0,2); //creating a new string of just the first two chars
            string remainString = str.Substring(2, strLength);  // creating a new string of the remaining chars
            

            return (remainString+firstTwo);
        }
    }
}
