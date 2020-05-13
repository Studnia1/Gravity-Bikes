using GravityBikes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data
{
    public interface IAuthRespository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string email, string password);
        Task<bool> UserExsist(string email);
    }
}
