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
         * Given an string representing an item number (a.k.a. SKU), return the discount percentage if the item is on sale.
         * If the item is not on sale, return 0.00.
         *
         * If the item number is empty or null, return 0.00.
         *
		 * Dictionary to start with
		 *
         * "KITCHEN4001" -> 0.20
         * "GARAGE1070" -> 0.15
         * "LIVINGROOM"	-> 0.10
         * "KITCHEN6073" -> 0.40
         * "BEDROOM3434" -> 0.60
         * "BATH0073" -> 0.15
         *
         * The item number should be case insensitive so "kitchen4001", "Kitchen4001", and "KITCHEN4001"
         * should all return 0.20.
         *
         * IsItOnSale("kitchen4001") → 0.20
         * IsItOnSale("") → 0.00
         * IsItOnSale("GARAGE1070") → 0.15
         * IsItOnSale("dungeon9999") → 0.00
         *
         */
        public double IsItOnSale(string itemNumber)
        {
            // First create a Dictionary that holds this data
            Dictionary<string, double> discounts = new Dictionary<string, double>();
            discounts.Add("kitchen4001", 0.20);
            discounts.Add("garage1070", 0.15);
            discounts.Add("livingroom", 0.10);
            discounts.Add("kitchen6073", 0.40);
            discounts.Add("bedroom3434", 0.60);
            discounts.Add("bath0073", 0.15);

            if (itemNumber != null && itemNumber != "")
                // Leslie, the best way to do this is
                //if (!string.IsNullOrEmpty(variable))
            {

                itemNumber = itemNumber.ToLower();
                // Now check the Dictionary you just created for the itemNumber
                if (discounts.ContainsKey(itemNumber))
                {
                    return discounts[itemNumber];
                }
                return 0.00;
            }
            return 0.00;
        }
    }
}
