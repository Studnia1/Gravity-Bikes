using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Dtos
{
    public class TicketsForListDto
    {
        public int LiftTicketID { get; set; }
        public int LiftTicketUseCount { get; set; }
        public int LiftTicketDaysCount { get; set; }
        public int LiftTicketPriceReduced { get; set; }
        public bool IsDayLimitedTicket { get; set; }
        public int LiftTicketPrice { get; set; }
        public string LiftTicketType { get; set; }
        public DateTime LimitStart { get; set; }
        public DateTime LimitStop { get; set; }
    }
}
