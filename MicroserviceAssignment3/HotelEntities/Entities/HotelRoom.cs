using System;
using System.Collections.Generic;
using System.Text;

namespace HotelEntities.Entities
{
    public class HotelRoom
    {
        public long RoomId { get; set; }
        public Room Room { get; set; }
    }
    public class HotelRoomList
    {
        public HotelRoomList()
        {
            Rooms = new List<HotelRoom>();
        }
        public long Id { get; set; }
        public long HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public List<HotelRoom> Rooms { get; set; }
    }
}
