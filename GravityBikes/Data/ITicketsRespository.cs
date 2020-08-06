using GravityBikes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data
{
    public interface ITicketsRespository
    {
        Task<IEnumerable<LiftTicket>> GetTickets();
        Task<LiftTicket> NewTicket(LiftTicket liftTicket);
    }
}
