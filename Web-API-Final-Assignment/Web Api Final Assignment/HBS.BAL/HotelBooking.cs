using HBS.BAL.Interface;
using HBS.DAL.Repository;
using HBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBS.BAL
{
    public class HotelBooking : IHotelBooking
    {
        private readonly IHotelRepository _hotelRepository;
        public HotelBooking(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public bool AvailRooms(DateTime date)
        {
            return _hotelRepository.AvailRooms(date);
        }

        public string BookRoom(Booking booking)
        {
            return _hotelRepository.BookRoom(booking);
        }

        public string CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public string CreateRoom(Room room)
        {
            return _hotelRepository.CreateRoom(room);
        }

        public string DeleteBooking(int id)
        {
            return _hotelRepository.DeleteBooking(id);
        }

        public List<HotelOnly> GetHotel()
        { 
            return _hotelRepository.GetHotel().OrderBy(h=>h.HotelName).ToList();
        }

        public List<Room> GetRooms()
        {
            var rooms = _hotelRepository.GetRooms();
            return rooms;   
        }

        public List<Room> GetRoomsByCategory(string Category)
        {
            return _hotelRepository.GetRoomsByCategory(Category);
        }

        public List<Room> GetRoomsByCity(string City)
        {
            return _hotelRepository.GetRoomsByCity(City);
        }

        public List<Room> GetRoomsByPincode(string Pincode)
        {
            return _hotelRepository.GetRoomsByPincode(Pincode);
        }

        public List<Room> GetRoomsByPrice(string Price)
        {
            return _hotelRepository.GetRoomsByPrice(Price);
        }

        public string UpdateBookingDate(int id,Booking booking)
        {
            return _hotelRepository.UpdateBookingDate(id,booking);
        }

        public string UpdateBookingStauts(int id,Booking booking)
        {
            return _hotelRepository.UpdateBookingStauts(id,booking);
        }
    }
}
