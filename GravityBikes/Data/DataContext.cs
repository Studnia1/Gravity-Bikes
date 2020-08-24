using GravityBikes.Data.Models;
using GravityBikes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace GravityBikes.Data
{
    public class DataContext : IdentityDbContext<User, Role, int,
        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });
        }

    }
}

