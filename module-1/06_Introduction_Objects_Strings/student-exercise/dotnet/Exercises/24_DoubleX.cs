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
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         DoubleX("axxbb") → true
         DoubleX("axaxax") → false
         DoubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            
            

            for (int i = 0; i < str.Length; i++)
            {
                if ( str[i] == 'x' && str[i + 1] == 'x')
                {
                    return true;
                }
                // must need to account for a string length of 0 and 1?  Throw out of range exception
            }
            return false;
        }
    }
}
