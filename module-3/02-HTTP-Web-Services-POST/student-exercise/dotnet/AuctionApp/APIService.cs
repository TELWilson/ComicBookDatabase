﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp
{
    public class APIService
    {
        private const string LaptopId = "00006"; 
        private readonly string API_URL = $"https://te-mockauction-server.azurewebsites.net/students/{LaptopId}/auctions";
        private readonly IRestClient client;

        public APIService()
        {
            client = new RestClient();
        }

        public APIService(IRestClient restClient)
        {
            client = restClient;
        }

        public List<Auction> GetAllAuctions()
        {
            RestRequest request = new RestRequest(API_URL);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                Console.WriteLine("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }

            return null;
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            RestRequest requestOne = new RestRequest(API_URL + "/" + auctionId);
            IRestResponse<Auction> response = client.Get<Auction>(requestOne);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                Console.WriteLine("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }

            return null;
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTitle)
        {
            RestRequest request = new RestRequest(API_URL + "?title_like=" + searchTitle);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                Console.WriteLine("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }

            return null;
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            RestRequest request = new RestRequest(API_URL + "?currentBid_lte=" + searchPrice);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Error occurred - unable to reach server.");
            }
            else if (!response.IsSuccessful)
            {
                Console.WriteLine("Error occurred - received non-success response: " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }

            return null;
        }

        public Auction AddAuction(Auction newAuction) {
            RestRequest request = new RestRequest(API_URL);

            request.AddJsonBody(newAuction);

            IRestResponse<Auction> response = this.client.Post<Auction>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not add the new auction");
                return null;

            }
            if (!response.IsSuccessful)
            {
                Console.WriteLine("Encountered an error adding the new auction" + response.ErrorMessage + " )" + response.StatusCode + " )");
                return null;
            }

            return response.Data;
        }

        public Auction UpdateAuction(Auction auctionToUpdate)
        {
            RestRequest request = new RestRequest(API_URL + "/" + auctionToUpdate.Id);

            request.AddJsonBody(auctionToUpdate);

            IRestResponse<Auction> response = this.client.Put<Auction>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not update the auction");
                return null;

            }
            if (!response.IsSuccessful)
            {
                Console.WriteLine("Encountered an error updating the auction" + response.ErrorMessage + " )" + response.StatusCode + " )");
                return null;
            }

            return response.Data;
        }

        public bool DeleteAuction(int auctionId)
        {
            RestRequest request = new RestRequest(API_URL + "/" + auctionId);

          

            IRestResponse response = this.client.Delete(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not delete the auction");
                return false;

            }
            if (!response.IsSuccessful)
            {
                Console.WriteLine("Encountered an error deleting the auction" + response.ErrorMessage + " )" + response.StatusCode + " )");
                return false;
            }

            return true;
        }
    }
}
