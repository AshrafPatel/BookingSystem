using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Domain.Entities
{
    public class TimeSlot
    {
        public Guid Id { get; set; }
        public Guid StaffId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IsBooked { get; set; }
    }
}
