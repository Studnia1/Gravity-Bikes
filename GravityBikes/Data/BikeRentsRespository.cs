using GravityBikes.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GravityBikes.Data
{
    public class BikeRentsRespository : IBikeRentsRespository
    {
        private readonly DataContext _context;

        public BikeRentsRespository(DataContext context)
        {
            _context = context;
        }

        public Task<bool> BikesToReservation()
        {
            throw new NotImplementedException();
        }

        public async Task<Bike> GetBike(int id)
        {
            var bike = await _context.Bikes.FirstOrDefaultAsync(u => u.BikeId == id);
            return bike; 
        }

        public async Task<IEnumerable<Bike>> GetBikes()
        {
            var bikes = await _context.Bikes.ToListAsync();
            return bikes;
        }
    }
}
