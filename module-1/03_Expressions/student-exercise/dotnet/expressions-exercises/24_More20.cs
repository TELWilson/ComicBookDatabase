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
         Return true if the given non-negative number is 1 or 2 more than a multiple of 20.
         (Hint: Think "mod".)
         More20(20) → false
         More20(21) → true
         More20(22) → true
         */
        public bool More20(int n)
        {
            bool nonNegNum = (n >= 0);

            if (nonNegNum)
            {
                if (n % 20 == 1)
                {
                    return true;
                }
                else if (n % 20 == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

    }
}
