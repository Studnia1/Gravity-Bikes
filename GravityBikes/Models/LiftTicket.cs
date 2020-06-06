using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data.Models
{
    public class LiftTicket
    {
        public int LiftTicketID { get; set; }
        public int LiftTicketUseCount { get; set; }
        public int LiftTicketDaysCount { get; set; }
        public string LiftTicketDiscountType { get; set; }
        public int LiftTicketPrice { get; set; }
        public string LiftTicketType { get; set; }
        public DateTime LiftTicketDateOfStart { get; set; }
        public DateTime LiftTicketDateOfStop { get; set; }
        public DateTime BikeDateOfHireStop { get; set; }

        LiftTicketReservation liftTicketReservation {get; set;}
        int LiftTicketReservationID {get; set;}
    }
}
