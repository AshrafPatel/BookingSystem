using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Domain.Entities
{
    public class RefreshToken
    {
        public string Token { get; set; } = default!;
        public string UserId { get; set; } = default!;
        public DateTime Expires { get; set; }
        public bool IsRevoked { get; set; }
    }
}
