using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data.Models
{
    public class BikePark
    {
        public int BikeParkID { get; set; }
        public int BikesCount { get; set; }
        public int ParkTicketLimit { get; set; }
        public int LiftTicketLimit { get; set; }
    }
}
