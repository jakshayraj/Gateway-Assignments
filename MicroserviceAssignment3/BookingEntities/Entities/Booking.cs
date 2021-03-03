using System;

namespace BookingEntities.Entities
{
    public class Booking
    {
        public long Id { get; set; }
        public string Number { get; set; }

        public DateTime PlaceOn { get; set; }
        public long HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public long RoomId { get; set; }
        public string Room { get; set; }
        public double Amount { get; set; }
    }
}
