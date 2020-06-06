using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data.Models
{
    public class LiftTicketReservation
    {
        public int LiftTicketReservationID { get; set; }
        public DateTime LiftTicketReservationDateOfOrder { get; set; }
        public DateTime LiftTicketReservationDateOfPayment { get; set; }
        public bool LiftTicketReservationIsPaid { get; set; }
        public int LiftTicketReservationOwnerId { get; set; }
        public ICollection<LiftTicket> ReservedLiftTickets { get; set; }

        public User user {get; set;}
        public int userID {get; set;}
    }
}
