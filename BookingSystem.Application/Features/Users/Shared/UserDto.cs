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
    }
}
