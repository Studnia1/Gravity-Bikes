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
        public string BikeModel { get; set; } /* < tu dokladniej przemyslec typ */
        public string BikeSize { get; set; } /* < tu dokladniej przemyslec typ */
        public string BikeGender { get; set; } /* < tu dokladniej przemyslec typ */
        public string BikeType { get; set; } /* < tu dokladniej przemyslec typ */

    }
}
