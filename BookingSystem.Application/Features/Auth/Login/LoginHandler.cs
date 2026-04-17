using BookingSystem.Application.Features.Users.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.Features.Auth.Login
{
    public class LoginHandler
    {
        public async Task<AuthResponseDto> Handle(LoginRequestDto request)
        {
            // 1. Find user
            // 2. Check password
            // 3. Generate JWT
            // 4. Generate refresh token
            // 5. Save refresh token
            // 6. Return DTO
            throw new NotImplementedException();
        }
    }
}
