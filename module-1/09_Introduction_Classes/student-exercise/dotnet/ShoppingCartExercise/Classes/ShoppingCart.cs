using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {
        /// <summary>
        /// The number of items in the shopping cart.  All shopping carts have 0 items by default
        /// </summary>
        public int TotalNumberOfItems { get; private set; }

        /// <summary>
        /// The total for the shopping cart.  All shopping carts have 0.0 owed by default
        /// </summary>
        public decimal TotalAmountOwed { get; private set; }

        /// <summary>
        /// Returns the result of TotalAmountOwed/TotalNumberOfItems
        /// </summary>
        /// <returns></returns>
        public decimal GetAveragePricePerItem()
        {
            if (TotalNumberOfItems > 0)
            {
                return TotalAmountOwed / TotalNumberOfItems;
            }
            else return 0;
            
                
            
        }

        /// <summary>
        /// Updates the TotalNumberOfItems and increases TotalAmountOwed by (pricePerItem * numberOfItems)
        /// </summary>
        /// <param name="numberOfItems"></param>
        /// <param name="pricePerItem"></param>
        public void AddItems(int numberOfItems, decimal pricePerItem)
        {
            TotalNumberOfItems = TotalNumberOfItems + numberOfItems;
            TotalAmountOwed = pricePerItem * numberOfItems;
        }

        /// <summary>
        /// Resets TotalNumberOfItems and TotalAmountOwed to 0.
        /// </summary>
        public void Empty()
        {
            TotalNumberOfItems = 0;
            TotalAmountOwed = 0;

        }




       
    }
}
