using GravityBikes.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GravityBikes.Data
{
    public interface IBikeRentsRespository
    {
        Task<IEnumerable<Bike>> GetBikes();
        Task<Bike> GetBike(int id);

        Task<bool> BikesToReservation();

    }
}
