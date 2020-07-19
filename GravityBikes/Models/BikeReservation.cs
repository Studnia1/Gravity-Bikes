using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data.Models
{
    public class BikeReservation
    {
        public int BikeReservationID { get; set; }

        public DateTime BikeReservationDateOfPayment { get; set; }
        public bool BikeReservationIsPaid { get; set; }
        public DateTime DateOfReservation { get; set; }
        public Bike ReservedBike { get; set; }
        public User user {get; set;}
        public int userID {get; set;}                
    }
}
