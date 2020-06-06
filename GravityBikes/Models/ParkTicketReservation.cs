using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data.Models
{
    public class ParkTicketReservation
    {
        public int ParkTicketReservationID { get; set; }
        public DateTime ParkTicketReservationDateOfOrder { get; set; }
        public DateTime ParkTicketReservationDateOfPayment { get; set; }
        public bool ParkTicketReservationIsPaid { get; set; }
        public int ParkTicketReservationOwnerId { get; set; }
        public ICollection<ParkTicket> ReservedParkTicket { get; set; }

        public User user {get; set;}
        public int userID {get; set;}
    }
}
