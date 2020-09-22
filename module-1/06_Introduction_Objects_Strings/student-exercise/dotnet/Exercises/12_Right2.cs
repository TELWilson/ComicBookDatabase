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
         Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start.
         The string length will be at least 2.
         Right2("Hello") → "loHel"
         Right2("java") → "vaja"
         Right2("Hi") → "Hi"
         */
        public string Right2(string str)
        { //need to make two new strings that are substrings of the original
            int strLength = str.Length - 2; //finding the length value for the substring for the new remainString
            string lastTwo = str.Substring(strLength, 2); //creating a new string of the last two chars
            string remainString = str.Substring(0, strLength);  // creating a new string of the remaining chars


            return (lastTwo + remainString);
        }
    }
}
