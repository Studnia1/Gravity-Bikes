using GravityBikes.Data.Models;
using GravityBikes.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;


namespace GravityBikes.Data
{
    public interface IBikeRentsRespository
    {
        Task<IEnumerable<Bike>> GetBikes();
        Task<Bike> GetBike(int id);

        Task<bool> BikesToReservation();
        Task<List<ReservedBikeViewModel>> AvailableBikes(string model, byte size);



    }
}
