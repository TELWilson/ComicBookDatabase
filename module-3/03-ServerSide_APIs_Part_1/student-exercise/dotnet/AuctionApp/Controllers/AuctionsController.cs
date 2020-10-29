﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao)
        {
            this.dao = auctionDao;
        }

      

        [HttpGet("{id}")]
        public Auction GetAuction(int id)
        {
            Auction auction = this.dao.Get(id);

            if (auction != null)
            {
                return auction;
            }
            return null;
        }


        [HttpGet]
        public List<Auction> GetAuctions(string title_like = "", double currentBid_lte = 0)
        {
            if (!string.IsNullOrEmpty(title_like) && currentBid_lte != 0)
            {
                return this.dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }
            if (!string.IsNullOrEmpty(title_like))
            {
                return this.dao.SearchByTitle(title_like);
            }
            if(currentBid_lte != 0)
            {
                return this.dao.SearchByPrice(currentBid_lte);
            }
           
            return this.dao.List();
        }

        [HttpPost]
        public ActionResult<Auction> AddAuction(Auction newAuction)
        {
            Auction result = this.dao.Create(newAuction);

            return Created("auctions/" + result.Id, result);
        }
    }
}
