using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 int values, return true if they are both in the range 30..40 inclusive, or they are both
         in the range 40..50 inclusive.
         In3050(30, 31) → true
         In3050(30, 41) → false
         In3050(40, 50) → true
         */
        public bool In3050(int a, int b)
        {
            // My struggle here, I think, is that both ranges include 40 and I don't know how to separate 
            //the 40 in the first range from the 40 in the second range.
            bool num30s = ((a >= 30 && a <= 40) && (b >= 30 && b <= 40));
            bool num40s = ((a >= 40 && a <= 50) && (b >= 40 && b <= 50));

            //if (firstValue || secondValue)
            //{
            //    return true;
            //}

            if (num30s || num40s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
