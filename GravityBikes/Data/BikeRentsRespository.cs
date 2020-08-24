using GravityBikes.Data.Models;
using GravityBikes.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<List<ReservedBikeViewModel>> AvailableBikes(string model, byte size)
        {
            var dates = await (from y in _context.BikeReservations
                               join x in _context.Bikes
                                on y.ReservedBike.BikeId equals x.BikeId
                               where x.BikeModel == model && x.BikeSize == size
                               group x.BikeModel by y.DateOfReservation into g
                               select new ReservedBikeViewModel
                               {
                                   BikeDate = g.Key,
                                   Count = g.Count()
                               }).ToListAsync();

            return dates;

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

        public async Task<Bike> NewBike(Bike bike)
        {
            await _context.Bikes.AddAsync(bike);
            await _context.SaveChangesAsync();
            return bike;
        }
    }
}
