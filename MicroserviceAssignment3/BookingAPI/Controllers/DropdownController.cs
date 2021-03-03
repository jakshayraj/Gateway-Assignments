using CommonObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookingsAPI.Services;
using System.Collections.Generic;
using System.Linq;
namespace OrderAPI.Controllers
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
        /// Get bookings
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetBooking")]
        public IEnumerable<DropdownDto> GetBooking()
        {
            return new BookingsService().GetBookings().Select(r => new DropdownDto { Id = r.Id, Type = r.Number });
        }
    }
}
