using System;
using System.Collections.Generic;
using CatCards.DAO;
using CatCards.Models;
using CatCards.Services;
using Microsoft.AspNetCore.Mvc;

namespace CatCards.Controllers
{
    [Route("/api/cards")] //base url for our methods
    [ApiController] //anything sent back from this is json
    public class CatController : ControllerBase
    {
        private readonly ICatCardDao cardDao;
        private readonly ICatFactService catFactService;
        private readonly ICatPicService catPicService;
        

        public CatController(ICatCardDao cardDao, ICatFactService catFact, ICatPicService catPic)
        {
            this.catFactService = catFact;
            this.catPicService = catPic;
            this.cardDao = cardDao;
        }

        [HttpGet]
        public List<CatCard> GetAllCards()
        {
            return cardDao.GetAllCards();
        }

        [HttpGet("{catCardId}")]
        public CatCard GetCard(int catCardId)
        {
            return cardDao.GetCard(catCardId);
        }

        [HttpGet("random")]
        public CatCard Random()
        {
            CatCard myCatCard = new CatCard();

            myCatCard.CatFact = catFactService.GetFact().Text;
            myCatCard.ImgUrl = catPicService.GetPic().File;

            return myCatCard;
        }

        [HttpPost]
        public CatCard SaveCard(CatCard cardToSave)
        {
            return cardDao.SaveCard(cardToSave);
        }

        [HttpPut("{catCardId}")]
        public bool UpdateCard(CatCard updatedCard)
        {
            return cardDao.UpdateCard(updatedCard);
        }

        [HttpDelete("{catCardId}")]
        public bool RemoveCard(int catCardId)
        {
            return cardDao.RemoveCard(catCardId);
        }

    }

    


}
