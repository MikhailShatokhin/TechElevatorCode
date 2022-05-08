using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.DAO;

namespace HotelReservations.Controllers
{
    [Route("hotels")] //http://localhost:<portnumber>/hotels
    [ApiController] //means that we are returning JSON
    public class HotelsController : ControllerBase
    {
        
        private static IHotelDao hotelDao;

        public HotelsController()
        {
            if (hotelDao == null)
            {
                hotelDao = new HotelMemoryDao();
            }
        }

        [HttpGet("ready")]
        // GET /hotels/ready
        public string Ready()
        {
            return "Server is ready.";
        }


        [HttpGet()]
        // GET /hotels
        public List<Hotel> ListHotels()
        {
            return hotelDao.List();
        }

        [HttpGet("{id}")]
        // GET /hotels/{id#}
        public ActionResult<Hotel> GetHotel(int id)
        {
            Hotel hotel = hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }
            else
            {
                return NotFound();
            }
        }
    }
}
