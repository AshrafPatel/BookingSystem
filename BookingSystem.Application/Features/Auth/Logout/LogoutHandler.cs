using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.Features.Auth.Logout
{
    public class LogoutHandler
    {
        public async Task Handle(string refreshToken)
        {
            // Find token in DB
            // Remove token from DB
        }
    }
}
