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
         Given an array of ints, return true if the array contains a 2 next to a 2 somewhere.
         Has22([1, 2, 2]) → true
         Has22([1, 2, 1, 2]) → false
         Has22([2, 1, 2]) → false
         */
        public bool Has22(int[] nums)
        {
            int first = 0;
            int second = 0;
           
            bool result = false;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                first = nums[i];
                second = nums[i + 1];
                if (first == 2 && first == second)  
                {
                    result = true;
                }

            }
            return result;
        }

    }
}
