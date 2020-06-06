using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data.Models
{
    public class Bike
    {
        public int BikeId { get; set; }
        public int BikePrice { get; set; }
        public int BikeHireDaysCount { get; set; }
        public DateTime BikeDateOfHireStart { get; set; }
        public DateTime BikeDateOfHireStop { get; set; }
        public bool BikeIsAvaible { get; set; }
        public string BikeModel { get; set; }
        public BikeSizes BikeSize { get; set; }
        public BikeGenders BikeGender { get; set; }
        public BikeTypes BikeType { get; set; }
        public enum BikeSizes
        {
            s = 0,
            m = 1,
            l = 2,
            xl = 3
        }
        public enum BikeGenders
        {
            male = 0,
            female = 1
        }

        public enum BikeTypes
        {
            downhill, freeride = 0,
            enduro = 1,
            forKids = 2
        }

        BikeReservation bikeReservation {get; set;}
        int BikeReservationID {get; set;}
    }
}
