using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Dtos
{
    public class NewTicketDto
    {
        [Required]
        public int LiftTicketUseCount { get; set; }
        [Required]
        public int LiftTicketDaysCount { get; set; }
        [Required]
        public int LiftTicketPrice { get; set; }
        [Required]
        public int LiftTicketPriceReduced { get; set; }
        [Required]
        public string LiftTicketType { get; set; }
        public bool IsDayLimitedTicket { get; set; }

        public DateTime LimitStart { get; set; }
        public DateTime LimitStop { get; set; }
    }
}
