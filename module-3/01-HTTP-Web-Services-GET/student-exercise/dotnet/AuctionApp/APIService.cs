using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp
{
    public class APIService
    {
        private readonly RestClient client;
        private readonly string BASE_URL;
        public APIService(string lapTopNumber)
            {
            this.client = new RestClient();

            this.BASE_URL = "https://te-mockauction-server.azurewebsites.net/students/" + lapTopNumber + "/";

        }
        // See https://te-mockauction-server.azurewebsites.net/swagger/index.html for API documentation and notes in the readme on relevant methods and working with studentId / id
        // Your requests should go to something like https://te-mockauction-server.azurewebsites.net/students/00006/...

        public List<Auction> GetAllAuctions()
        {
            RestRequest request = new RestRequest(this.BASE_URL + "auctions");

            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            return response.Data;
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            RestRequest request = new RestRequest(this.BASE_URL + "auctions/" + auctionId);

            IRestResponse<Auction> response = client.Get<Auction>(request);

            return response.Data;
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTitle)
        {
            RestRequest request = new RestRequest(this.BASE_URL + "auctions/?title_like=" + searchTitle);

            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            return response.Data;
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            RestRequest request = new RestRequest(this.BASE_URL + "auctions/?currentBid=" + searchPrice);

            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            return response.Data;
        }
    }
}
