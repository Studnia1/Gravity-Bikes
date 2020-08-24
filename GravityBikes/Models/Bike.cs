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
        public string BikeModel { get; set; }
        public byte BikeSize { get; set; }
        public byte BikeGender { get; set; }
        public string BikeDescription { get; set; }
        public string Url { get; set; }
        public string PublicId { get; set; }

    }
}
