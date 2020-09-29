using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// Represents an auction that only accepts bids over a specific amount (a reserve amount)
    /// </summary>

    public class ReserveAuction : Auction
    {
        public ReserveAuction(int reserveAmount, string name) : base(name)
        {
            this.ReserveAmount = reserveAmount;
        }

        public int ReserveAmount { get; set; }

        public override bool PlaceBid(Bid offeredBid)
        {
            //Console.WriteLine("Hello inheritance");
            //Only accept bids that meet reserve amount

            if (offeredBid.BidAmount >= this.ReserveAmount)
            {
                return base.PlaceBid(offeredBid);
            }

            Console.WriteLine("Rejecting: " + offeredBid);
            return false;
        }
    }
}
