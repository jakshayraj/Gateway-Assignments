using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBS.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public Nullable<int> RoomId { get; set; }
        public string StautsOfBooking { get; set; }
    }
}
