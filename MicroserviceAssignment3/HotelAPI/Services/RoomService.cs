using HotelEntities.Entities;
using System.Collections.Generic;

namespace HotelAPI.Services
{
    public class RoomService
    {
        public List<Room> GetRooms()
        {
            var rooms = new List<Room>();
            for (int i = 1; i <= 7; i++)
            {
                rooms.Add(new Room
                {
                    Id = i,
                    Type = $"Room_{i}",
                });
            }
            return rooms;
        }
    }
}
