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
         Given a non-empty string like "Code" return a string like "CCoCodCode".
         StringSplosion("Code") → "CCoCodCode"
         StringSplosion("abc") → "aababc"
         StringSplosion("ab") → "aab"
         */
        public string StringSplosion(string str)
        {// split into chars?  Then return first char + first two chars + first three chars + first four chars + ...
            // It is unclear if you stop at 4 chars or keep running through if your string is 50 chars long
            // probably needs a loop
            int character = 0;
            for (int i = 0; i < str.Length ; i++)
            {

            }
            return null;
        }
    }
}
