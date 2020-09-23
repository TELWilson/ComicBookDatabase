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
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            string result = "";  //create a string to return as the result
            for (int i = 0; i < str.Length; i++ )  //loop though
            {
                //int index = str.IndexOf('x');
                if (i == 0 || i == str.Length-1) // If your index is equal to zero or the last index, want to keep 1st and last value no matter what
                {
                    result += str.Substring(i, 1);  // add the i index character to the result
                }
                else if (str.Substring(i,1) != "x")  // if the value at index i does not equal x
                {
                    result += str.Substring(i, 1);  // add the i index character to the result
                }
            }
            return result;
        }
    }
}
