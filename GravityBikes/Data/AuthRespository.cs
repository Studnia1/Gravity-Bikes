using GravityBikes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data
{
    public class AuthRespository : IAuthRespository
    {
        private readonly DataContext _context;
        public AuthRespository(DataContext context)
        {
            _context = context;
        }

        public DataContext Context { get; }

        public Task<User> Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> Register(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExsist(string email)
        {
            throw new NotImplementedException();
        }
    }
}
