using InheritanceLecture.Auctioneering;
using System;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new general auction
            Console.WriteLine("Starting a general auction");
            Console.WriteLine("-----------------");

            Auction generalAuction = new Auction("UP");

            generalAuction.PlaceBid(new Bid("Matt", 1));
            generalAuction.PlaceBid(new Bid("John", 23));
            generalAuction.PlaceBid(new Bid("Rick Astley", 13));

            //Bid sneakyBid = new Bid("Matt", -5000);
            //generalAuction.AllBids.Add(sneakyBid);

            //....
            // This might go on until the auction runs out of time or hits a max # of bids

            // Add a reserve auction where bids don't count if they're below a threshhold
            ReserveAuction reserveAuction = new ReserveAuction(150, "Johns Car");
            reserveAuction.PlaceBid(new Bid("Matt", 50));
            reserveAuction.PlaceBid(new Bid("Katie", 5000));

            //Add a buyout auction where a high bid can win the auction outright
            BuyoutAuction buyAuction = new BuyoutAuction("Kryptonite");
            buyAuction.PlaceBid(new Bid("Bruce Wayne", 42));
            buyAuction.PlaceBid(new Bid("Clark Kent", 250));
            buyAuction.PlaceBid(new Bid("Bruce Wayne", 1000000));
            buyAuction.PlaceBid(new Bid("Clark Kent", 1000001));
            //buyAuction.EndAuction();

            Console.ReadLine();
        }
    }
}
