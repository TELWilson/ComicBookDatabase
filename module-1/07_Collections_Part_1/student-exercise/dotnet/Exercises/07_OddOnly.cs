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
         Given an array of Integers, return a List of Integers containing just the odd values.
         OddOnly( {112, 201, 774, 92, 9, 83, 41872} ) -> [201, 9, 83]
         OddOnly( {1143, 555, 7, 1772, 9953, 643} ) -> [1143, 555, 7, 9953, 643]
         OddOnly( {734, 233, 782, 811, 3, 9999} ) -> [233, 811, 3, 9999]
         */
        public List<int> OddOnly(int[] integerArray)
        {

            //YOU NEED TO CONVERT THE ARRAY TO A LIST
            //int oddInt = 0;
            
            List<int> oddList = new List<int>();  // create return list
            //for (int i = 0; i < integerArray.Length - 1; i++)  // needs to be a foreach
            foreach (int oddInt in integerArray)
            {
                if (oddInt % 2 != 0 )  // evaluating the value of at the index to see if it is divisible by 2
                {
                    oddList.Add(oddInt);
                }
            }

            

            return oddList;

        }

    }
}
