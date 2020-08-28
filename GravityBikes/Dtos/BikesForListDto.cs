using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Dtos
{
    public class BikesForListDto
    {
        public int BikeId { get; set; }
        public int BikePrice { get; set; }
        public string BikeModel { get; set; }
        public byte BikeSize { get; set; }
        public byte BikeGender { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

    }
}
