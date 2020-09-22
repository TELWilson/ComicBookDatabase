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
        Given 2 strings, a and b, return a string of the form short+long+short, with the shorter string
        on the outside and the longer string on the inside. The strings will not be the same length, but
        they may be empty (length 0).
        ComboString("Hello", "hi") → "hiHellohi"
        ComboString("hi", "Hello") → "hiHellohi"
        ComboString("aaa", "b") → "baaab"
        */
        public string ComboString(string a, string b)
        {
            //int aString = a.Length;
            //int bString = b.Length;
            
            
            if (a.Length > b.Length) //We need to check the length of each string
            {
                string shortString = b;  // problem, currently assigning value to null
                string longString = a; // trying to call whichever string is larger a long and shorter short.
                return (shortString + longString + shortString);
               
            }
            else
            {
                string shortString = b;
                string longString = a;
                return (longString + shortString + longString);
            }



        }
    }
}
