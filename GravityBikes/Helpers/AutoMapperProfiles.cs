using AutoMapper;
using GravityBikes.Data.Models;
using GravityBikes.Dtos;

namespace GravityBikes.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Bike, BikesForListDto>();
            CreateMap<LiftTicket, TicketsForListDto>();
            CreateMap<UserForRegisterDto, User>();
        }
    }
}
