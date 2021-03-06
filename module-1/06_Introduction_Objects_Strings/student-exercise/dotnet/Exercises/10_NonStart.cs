﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given 2 strings, return their concatenation, except omit the first char of each. The strings will
         be at least length 1.
         NonStart("Hello", "There") → "ellohere"
         NonStart("java", "code") → "avaode"
         NonStart("shotl", "java") → "hotlava"
         */
        public string NonStart(string a, string b)
        {
            int aLength = a.Length-1; //Finding the lengths of the strings to use in the length part of the .substring
            int bLength = b.Length-1;


            return (a.Substring(1, aLength)+b.Substring(1, bLength));
        }
    }
}
