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
        public bool BikeIsAvaible { get; set; }
        public string BikeModel { get; set; }
        public byte BikeSize { get; set; }
        public byte BikeGender { get; set; }
        public byte BikeType { get; set; }
        public string PhotoUrl { get; set; }

    }
}
