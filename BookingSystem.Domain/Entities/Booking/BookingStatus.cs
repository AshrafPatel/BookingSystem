using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Domain.Entities.Booking
{
    public enum BookingStatus
    {
        PENDING = 0,
        CONFIRMED = 1,
        CANCELLED = 2
    }
}
