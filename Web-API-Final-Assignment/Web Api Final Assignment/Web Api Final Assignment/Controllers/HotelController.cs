﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using HBS.BAL;
using HBS.BAL.Interface;
using HBS.Models;

namespace Web_Api_Final_Assignment.Controllers
{
    [EnableCors(origins: "https://localhost:44357/", headers:"*", methods:"*")]
    [BasicAuth]
    public class HotelController : ApiController
    {

        private readonly IHotelBooking _hotelBooking;

        public HotelController(IHotelBooking hotelBooking)
        {
            _hotelBooking = hotelBooking;
        }

        // GET: api/Hotel/HotelDetails
        [HttpGet]
        [Route("api/Hotel/HotelDetails")]
        public IHttpActionResult HotelDetails()
        {
            return Ok(_hotelBooking.GetHotel());
        }
        

        // GET: api/Hotel/RoomDetails
        [HttpGet]
        [Route("api/Hotel/RoomDetails/{City?}/{Pincode?}/{Price?}/{Category?}")]
        public IHttpActionResult RoomDetails(string City=null, string Pincode = null, string Price = null, string Category = null)
        {
            if (City != null)
            {
                if (_hotelBooking.GetRoomsByCity(City).Count() != 0)
                {
                    return Ok(_hotelBooking.GetRoomsByCity(City));
                }
                else 
                { 
                    return NotFound(); 
                }
            }
            else if (Pincode != null)
            {
                if (_hotelBooking.GetRoomsByPincode(Pincode).Count() != 0)
                {
                    return Ok(_hotelBooking.GetRoomsByPincode(Pincode));
                }
                else
                {
                    return NotFound();
                }
            }
            else if (Price != null)
            {
                if (_hotelBooking.GetRoomsByPrice(Price).Count() != 0)
                {
                    return Ok(_hotelBooking.GetRoomsByPrice(Price));
                }
                else
                {
                    return NotFound();
                }
            }
            else if (Category != null)
            {
                if (_hotelBooking.GetRoomsByCategory(Category).Count() != 0)
                {
                    return Ok(_hotelBooking.GetRoomsByCategory(Category));
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return Ok(_hotelBooking.GetRooms());
            }
        }
        // GET: api/Hotel/RoomAvailable
        [HttpGet]
        [Route("api/Hotel/RoomAvailable/{date}")]
        public IHttpActionResult RoomAvailable(DateTime date)
        {
            return Ok(_hotelBooking.AvailRooms(date));
        }


        // POST: api/Hotel/PostHotel
        [HttpPost]
        [Route("api/Hotel/PostHotel")]
        public HttpResponseMessage PostHotel([FromBody]Hotel hotel)
        {
            return Request.CreateResponse(HttpStatusCode.Created, _hotelBooking.CreateHotel(hotel));
        }

        // POST: api/Hotel/PostRoom
        [HttpPost]
        [Route("api/Hotel/PostRoom")]
        public HttpResponseMessage PostRoom([FromBody]Room room)
        {
            return Request.CreateResponse(HttpStatusCode.Created, _hotelBooking.CreateRoom(room));
        }

        // POST: api/Hotel/PostBooking
        [HttpPost]
        [Route("api/Hotel/PostBooking")]
        public HttpResponseMessage PostBooking([FromBody] Booking booking)
        {
            return Request.CreateResponse(HttpStatusCode.Created, _hotelBooking.BookRoom(booking));
        }

        // PUT: api/Hotel/PutBookingDate/5
        [HttpPut]
        [Route("api/Hotel/PutBookingDate/{id}")]
        public HttpResponseMessage PutBookingDate(int id,[FromBody] Booking booking)
        {
            return Request.CreateResponse(HttpStatusCode.Created, _hotelBooking.UpdateBookingDate(id, booking));
        }

        // PUT: api/Hotel/PutBookingStatus/5
        [HttpPut]
        [Route("api/Hotel/PutBookingStatus/{id}")]
        public HttpResponseMessage PutBookingStatus(int id,[FromBody] Booking booking)
        {
            return Request.CreateResponse(HttpStatusCode.Created, _hotelBooking.UpdateBookingStauts(id, booking));
        }

        // DELETE: api/Hotel/Delete/5
        [Route("api/Hotel/Delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse(HttpStatusCode.Created, _hotelBooking.DeleteBooking(id));
        }
    }
}
