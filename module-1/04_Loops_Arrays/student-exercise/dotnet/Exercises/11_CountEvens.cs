﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Return the number of even ints in the given array. Note: the % "mod" operator computes the
         remainder, e.g. 5 % 2 is 1.
         CountEvens([2, 1, 2, 3, 4]) → 3
         CountEvens([2, 2, 0]) → 3
         CountEvens([1, 3, 5]) → 0
         */
        public int CountEvens(int[] nums)
        {
            //I already have an array, right?  Do I need to create a new one?  The answer should only be a single value
            int numEven = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0) //Do I need to make this equal to a variable?
                {
                    numEven++; // come up with a way to count how many even values there are

                      //The loop must have stopped after the first element since it was even
                } //what did I do that told it to stop running through the loop?
            }
            return numEven;

            
        }

    }
}
