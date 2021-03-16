﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HBS.Models;

namespace HBS.BAL.Interface
{
    public interface IHotelBooking
    {
        string CreateHotel(Hotel hotel);
        string CreateRoom(Room room);
        List<HotelOnly> GetHotel();
        List<Room> GetRooms();
        List<Room> GetRoomsByCity(string City);
        List<Room> GetRoomsByPincode(string Pincode);
        List<Room> GetRoomsByPrice(string price);
        List<Room> GetRoomsByCategory(string Category);
        bool AvailRooms(DateTime date);
        string BookRoom(Booking booking);
        string UpdateBookingDate(int id,Booking booking);
        string UpdateBookingStauts(int id,Booking booking);
        string DeleteBooking(int id);

    }
}