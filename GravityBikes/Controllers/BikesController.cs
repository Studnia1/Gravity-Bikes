using AutoMapper;
using GravityBikes.Data;
using GravityBikes.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GravityBikes.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BikesController : ControllerBase
    {
        private readonly IBikeRentsRespository _repo;
        private readonly IMapper _mapper;
        public BikesController(IBikeRentsRespository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetBikes()
        {
            var bikes = await _repo.GetBikes();
            var bikesToReturn = _mapper.Map<IEnumerable<BikesForListDto>>(bikes);

            return Ok(bikesToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBike(int id)
        {
            var bike = await _repo.GetBike(id);
            var bikeToReturn = _mapper.Map<BikesForListDto>(bike);

            return Ok(bikeToReturn);
        }

    }
}
