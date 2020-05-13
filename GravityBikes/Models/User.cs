using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Data.Models
{
    public class User
    {
        public int UserID { get; set; }
        public byte[] PasswordHash  { get; set; }   
        public byte[] PasswordSalt  { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public bool IsUserActive { get; set; }
        public bool IsUserVerifed { get; set; }
        public bool AllowUserMarketing { get; set; }
        public DateTime UserCreatioDateTime { get; set; }
    }
}
