using GravityBikes.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data.Models
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime Created { get; set; }


        public List<ParkTicketReservation> ParkTicketReservations {get; set;}
        public List<LiftTicketReservation> LiftTicketReservations {get; set;}
        public List<BikeReservation> BikeReservations {get; set;}
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
