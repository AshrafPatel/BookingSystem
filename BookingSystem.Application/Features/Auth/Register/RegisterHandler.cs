using BookingSystem.Application.Features.Auth.Login;
using BookingSystem.Application.Features.Users.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.Features.Auth.Register
{
    public class RegisterHandler
    {
        public async Task<AuthResponseDto> Handle(RegisterRequestDto request)
        {
            // 1. Create user
            // 2. Generate JWT
            // 3. Generate refresh token
            // 4. Save refresh token
            // 5. Return DTO
            throw new NotImplementedException();
        }
    }
}
