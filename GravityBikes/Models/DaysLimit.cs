using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data.Models
{
    public class DaysLimit
    {
        public int DaysLimitID { get; set; }
        public int ParkTicketLimit { get; set; }
        public int LiftTicketLimit { get; set; }
        public int ParkTicketActuallyCount { get; set; }
        public int LiftTicketActuallyCount { get; set; }
        public DateTime LimitDate { get; set; }
    }
}
