using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookingsAPI.Services;
using BookingEntities.Entities;
using System.Collections.Generic;

namespace OrderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly ILogger<BookingController> _logger;

        public BookingController(ILogger<BookingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Booking> GetBooking()
        {
            return new BookingsService().GetBookings();
        }


        [HttpGet, Route("GetBooking/{id}")]
        public IEnumerable<Booking> GetBooking(long id)
        {
            return new BookingsService().GetBookings(id: id);
        }

    }
}
