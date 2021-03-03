using CommonObjects.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using APIGateway.Util;

namespace APIGateway.Controllers
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
        ///  Get Hotels
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetHotels")]
        [RequestRateLimit(Name = "Limit Request Number", Seconds = 5)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IEnumerable<DropdownDto>> GetHotels()
        {
            var hotel = await HttpCall.GetRequest<List<DropdownDto>>("https://localhost:5002/Dropdown/GetHotel");
            var rooms = await HttpCall.GetRequest<List<DropdownDto>>("https://localhost:5002/Dropdown/GetRooms");
            hotel.AddRange(rooms);
            return hotel;
        }
    }
}
