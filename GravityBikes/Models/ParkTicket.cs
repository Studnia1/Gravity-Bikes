using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data.Models
{
    public class ParkTicket
    {
        public int ParkTicketID { get; set; }
        public int ParkTicketDaysCount { get; set; }
        public string ParkTicketDiscountType { get; set; }
        public int ParkTicketPrice { get; set; }
        public DateTime ParkTicketDateOfStart { get; set; }
        public DateTime ParkTicketDateOfStop { get; set; }

        ParkTicketReservation parkTicketReservation {get; set;}
        int ParkTicketReservationID {get; set;}
    }
}
