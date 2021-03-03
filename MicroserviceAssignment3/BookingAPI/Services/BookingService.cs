using System;
using System.Collections.Generic;
using System.Linq;
using BookingEntities.Entities;

namespace BookingsAPI.Services
{
    public class BookingsService
    {
        public IEnumerable<Booking> GetBookings(long? id = null)
        {
            var Bookingss = new List<Booking>();
            var Hotels = GetHotels();
            if (id != null)
            {
                Hotels = Hotels.Where(r => r.HotelId == id);
            }
            foreach (var Hotel in Hotels)
            {
                for (int i = 1; i <= 3; i++)
                {
                    Bookingss.Add(new Booking
                    {
                        Id = i,
                        Number = $"{Hotel.Name}_BookingsNumber_{i}",
                        Amount = (double)i * 4.96,
                        Room = $"Room_{i}",
                        RoomId = i,
                        PlaceOn = DateTime.Now.AddMinutes(i * (-10)),
                        HotelId = Hotel.HotelId,
                        Hotel = Hotel
                    });
                }
            }
            return Bookingss;
        }

        private IEnumerable<Hotel> GetHotels()
        {
            var Hotels = new List<Hotel>();
            for (int i = 1; i <= 3; i++)
            {
                Hotels.Add(new Hotel
                {
                    Id = i,
                    HotelId = i,
                    Name = $"Hotel_{i}",
                    Address = $"Address_{i}"
                });
            }
            return Hotels;
        }
    }
}
