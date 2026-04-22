using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application.Features.Auth.RefreshToken
{
    public class RefreshTokenResponseDto
    {
        public required string AccessToken { get; set; } 
        public required string RefreshToken { get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool IsRevoked { get; set; }
    }
}
