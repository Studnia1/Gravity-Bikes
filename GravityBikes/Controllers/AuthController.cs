using GravityBikes.Data;
using GravityBikes.Data.Models;
using GravityBikes.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GravityBikes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRespository _repo;
        public AuthController(IAuthRespository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register (UserForRegisterDto userForRegisterDto) 
        {

            userForRegisterDto.Email = userForRegisterDto.Email.ToLower();

            if (await _repo.UserExsist(userForRegisterDto.Email))
                return BadRequest("Email is already used");

            var userToCreate = new User
            {
                UserEmail = userForRegisterDto.Email
            };

            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);
        }
    }
}