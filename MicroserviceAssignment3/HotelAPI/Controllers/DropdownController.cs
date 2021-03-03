using CommonObjects.Models;
using HotelAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
namespace HotleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DropdownController : ControllerBase
    {
        private readonly ILogger<DropdownController> _logger;

        public DropdownController(ILogger<DropdownController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get rooms
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetRooms")]
        public IEnumerable<DropdownDto> GetRooms()
        {
            return new RoomService().GetRooms().Select(r => new DropdownDto { Id = r.Id, Type = r.Type });
        }

        /// <summary>
        ///  Get hotels
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetHotel")]
        public IEnumerable<DropdownDto> GetHotel()
        {
            return new HotelService().GetHotels().Select(r => new DropdownDto { Id = r.Id, Type = r.Name });
        }
    }
}
