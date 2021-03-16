using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBS.Models
{
    public class HotelOnly
    {
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Nullable<int> Pincode { get; set; }
        public string ContactNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
    }
}
