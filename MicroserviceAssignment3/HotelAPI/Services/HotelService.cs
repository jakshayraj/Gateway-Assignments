using HotelEntities.Entities;
using HotelAPI.Services;
using RestaurantEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAPI.Services
{
    public class HotelService
    {
        public List<Hotel> GetHotels()
        {
            var Hotels = new List<Hotel>();
            for (int i = 1; i <= 7; i++)
            {
                Hotels.Add(new Hotel
                {
                    Id = i,
                    Name = $"Hotel_{i}",
                    Address = new Address
                    {
                        Id = i,
                        Street = $"Street_{i}",
                        Number = i,
                        City = $"City_{i}",
                        State = $"State_{i}",
                        Zip = $"Zip_{i}",
                        Country = $"Country_{i}"
                    },
                    Star = i * 5
                });
            }
            return Hotels;
        }


        public HotelRoomList GetRoomList(long id)
        {
            var Hotel = GetHotels().Find(r => r.Id == id);
            var menu = new HotelRoomList()
            {
                Id = 1,
                Hotel = Hotel,
                HotelId = Hotel.Id
            };

            var rooms = new RoomService().GetRooms();
            for (int i = 0; i < rooms.Count; i++)
            {
                var room = rooms[i];
                menu.Rooms.Add(new HotelRoom
                {
                    Room = room,
                   RoomId = room.Id
                });
            }
            return menu;
        }
    }
}
