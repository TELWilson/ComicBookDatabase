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
         * Modify and return the given Dictionary as follows: if "Peter" has more than 0 money, transfer half of it to "Paul",
         * but only if Paul has less than $10s.
         *
         * Note, monetary amounts are specified in cents: penny=1, nickel=5, ... $1=100, ... $10=1000, ...
         *
         * RobPeterToPayPaul({"Peter": 2000, "Paul": 99}) → {"Peter": 1000, "Paul": 1099}
         * RobPeterToPayPaul({"Peter": 2000, "Paul": 30000}) → {"Peter": 2000, "Paul": 30000}
         *
         */
        public Dictionary<string, int> RobPeterToPayPaul(Dictionary<string, int> peterPaul)
        {

            //should not have to create a new dictionary
            int petersCents = peterPaul["Peter"]; //assigning the int value for key "peter"
            int paulsCents = peterPaul["Paul"]; // assigning the int value for key "paul"

            if (petersCents > 0 && paulsCents < 1000)  // checking the parameters set in the problem, peter more than 0, paul less than 10
            {
                petersCents = petersCents / 2; //trying to remove half of peters money
                paulsCents = petersCents + paulsCents; //trying to add half of peters cents to pauls cents
                peterPaul["Peter"] = petersCents;
                peterPaul["Paul"] = paulsCents;
                return peterPaul; // hoping this returns the new values
            }  
            return peterPaul;


            
        }
    } //(peterPaul["Peter"] = petersCents) + (peterPaul["Paul"]= paulsCents)
}
