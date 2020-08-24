using GravityBikes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public string PublicId { get; set; }
        public Bike Bike { get; set; }
        public int BikeId { get; set; }
    }
}
