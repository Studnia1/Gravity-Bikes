using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Dtos
{
    public class BikeForCreationDto
    {
        public int bikePrice { get; set; }
        public string bikeModel { get; set; }
        public bool isMale { get; set; }
        public bool isFemale { get; set; }
        public byte sCount { get; set; }
        public byte mCount { get; set; }
        public byte lCount { get; set; }
        public byte xlCount { get; set; }
        public string description { get; set; }


        public string Url { get; set; }
        public IFormFile file { get; set; }
        public string PublicId { get; set; }
    }
}
