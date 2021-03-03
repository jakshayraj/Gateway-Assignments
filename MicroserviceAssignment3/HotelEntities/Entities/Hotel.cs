using RestaurantEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelEntities.Entities
{
    public class Hotel
    {
        public Hotel()
        {

        }
        public long Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public int Star { get; set; }
    }
}
