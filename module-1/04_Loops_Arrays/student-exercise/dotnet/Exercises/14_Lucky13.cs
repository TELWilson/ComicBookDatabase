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
         Given an array of ints, return true if the array contains no 1's and no 3's.
         Lucky13([0, 2, 4]) → true
         Lucky13([1, 2, 3]) → false
         Lucky13([1, 2, 4]) → false
         */
        public bool Lucky13(int[] nums)
        {
            bool result = true;

            for(int i = 0; i < nums.Length; i++) //starting a for loop to cycle through array values
            {
                if (nums[i] == 1 || nums[i] == 3)  //if the value is 1 or 3, return false
                {
                    result = false;
                }
                 
            }


            return result;
        }

    }
}
