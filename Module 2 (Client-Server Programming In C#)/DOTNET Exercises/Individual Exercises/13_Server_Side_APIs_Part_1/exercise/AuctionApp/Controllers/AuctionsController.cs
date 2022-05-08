using System.Collections.Generic;
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

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionMemoryDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        [HttpGet("ready")]
        public string Ready()
        {
            return "Server ready.";
        }

        [HttpGet()]
        public ActionResult<List<Auction>> List(string title_like = "", double currentBid_lte = 0)
        {
            if(title_like == "" && currentBid_lte == 0)
            {
                return dao.List();
            }
            else if(currentBid_lte > 0 && title_like != null)
            {
                return dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }
            else if (currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }
            else if(title_like != null)
            {
                return dao.SearchByTitle(title_like);
            }
            else
            {
                //if(dao.List().Count>0)
                //{
                //    return dao.List();
                //}
                return dao.List();
            }

        }

        [HttpGet("/auctions/{id}")]
        public ActionResult<Auction> Get(int id)
        {
            Auction auction = dao.Get(id);

            if (auction != null)
            {
                return auction;
            }
            else
            { 
                return null;
            }
        }

        [HttpPost()]
        public ActionResult<Auction> Create(Auction auction)
        {
            Auction added = dao.Create(auction);
            return Created($"/auctions/{added.Id}", added);
        }

        //[HttpGet("/auction?title_like=")]
        //public ActionResult<Auction> SearchByTitle(string searchTerm)
        //{
        //    Auction auction = dao.Get(searchTerm);
        //    if (auction == null)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return auction;
        //    }
            
        //}
    }
}
