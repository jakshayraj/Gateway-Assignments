using HotelEntities.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HotelAPI.Services;
using RestaurantEntities.Entities;
using System.Collections.Generic;

namespace HotelAPI.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly ILogger<RoomController> _logger;

        public RoomController(ILogger<RoomController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get rooms
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetRooms")]
        public IEnumerable<Room> Get()
        {
            return new RoomService().GetRooms();
        }
    }
}
