using GravityBikes.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data
{
    public class TicketsRespository : ITicketsRespository
    {
        private readonly DataContext _context;
        public TicketsRespository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<LiftTicket>> GetTickets()
        {
            var bikes = await _context.LiftTickets.ToListAsync();
            return bikes;
        }
        public async Task<LiftTicket> NewTicket(LiftTicket liftTicket)
        {
            await _context.LiftTickets.AddAsync(liftTicket);
            await _context.SaveChangesAsync();
            return liftTicket;
        }

    }
}
