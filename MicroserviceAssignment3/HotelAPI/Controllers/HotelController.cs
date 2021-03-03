using HotelAPI.Services;
using HotelEntities.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantEntities.Entities;
using System.Collections.Generic;

namespace HotleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly ILogger<HotelController> _logger;

        public HotelController(ILogger<HotelController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get hotels
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetHotels")]
        public IEnumerable<Hotel> Get()
        {
            return new HotelService().GetHotels();
        }

        /// <summary>
        /// Get hotel room list
        /// </summary>
        /// <param name="dto">request dto</param>
        /// <returns>response dto</returns>
        [HttpGet, Route("GetHotelRoomList/{id}")]
        public HotelRoomList GetHotelRoomList(long id)
        {
            return new HotelService().GetRoomList(id: id);
        }
    }
}
