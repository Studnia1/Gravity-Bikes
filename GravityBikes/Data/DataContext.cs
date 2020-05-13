using GravityBikes.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<BikePark> BikeParks { get; set; }
        public DbSet<BikeReservation> BikeReservations { get; set; }
        public DbSet<DaysLimit> DaysLimits { get; set; }
        public DbSet<LiftTicket> LiftTickets { get; set; }
        public DbSet<LiftTicketReservation> LiftTicketReservations { get; set; }
        public DbSet<ParkTicket> ParkTickets { get; set; }
        public DbSet<ParkTicketReservation> ParkTicketReservations { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
