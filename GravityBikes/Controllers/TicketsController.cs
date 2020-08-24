using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GravityBikes.Data;
using GravityBikes.Data.Models;
using GravityBikes.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GravityBikes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class TicketsController : Controller
    {
        private readonly ITicketsRespository _repo;
        private readonly IMapper _mapper;

        public TicketsController(ITicketsRespository repo, IMapper mapper)
        {
            _repo= repo;
            _mapper = mapper;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetTickets()
        {
            var tickets = await _repo.GetTickets();
            var bikesToReturn = _mapper.Map<IEnumerable<TicketsForListDto>>(tickets);

            return Ok(bikesToReturn);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost("newticket")]
        public async Task<IActionResult> AddNewTicket (NewTicketDto newTicketDto)
        {
            var ticketToCreate = new LiftTicket
            {
                LiftTicketUseCount = newTicketDto.LiftTicketUseCount,
                LiftTicketDaysCount = newTicketDto.LiftTicketDaysCount,
                LiftTicketPriceReduced = newTicketDto.LiftTicketPriceReduced,
                LiftTicketPrice = newTicketDto.LiftTicketPrice,
                LiftTicketType = newTicketDto.LiftTicketType,
                IsDayLimitedTicket = newTicketDto.IsDayLimitedTicket
            };
            if(newTicketDto.IsDayLimitedTicket)
            {
                ticketToCreate.LimitStart = newTicketDto.LimitStart;
                ticketToCreate.LimitStop = newTicketDto.LimitStop;
            }
            var registeredTicker = await _repo.NewTicket(ticketToCreate);
            return StatusCode(201);

        }
    }
}