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
        Given a string, return a string length 1 from its front, unless front is false, in which case
        return a string length 1 from its back. The string will be non-empty.
        TheEnd("Hello", true) → "H"
        TheEnd("Hello", false) → "o"
        TheEnd("oh", true) → "o"
        */
        public string TheEnd(string str, bool front)
        {
            int length = str.Length - 1; // need to know the length of the string to detemine the index of the last char
            if (front)  // front is true
            {
                return str.Substring(0, 1);  // returns the first character
            }
            return str.Substring(length ,1) ;  // returns the last character
        }
    }
}
