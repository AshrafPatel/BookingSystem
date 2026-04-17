using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.Features.Users.Shared
{
    public class UserDto
    {
        public required string Id { get; set; }
        public required string Email { get; set; }
        public IEnumerable<string> Roles { get; set; } = [];
        //Add other user properties as needed
    }
}
