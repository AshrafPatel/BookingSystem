using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Domain.Entities
{
    public class StaffProfile
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public string? DisplayName { get; set; } //What sort of Doctor, Therapist, etc
        public ICollection<TimeSlot>? TimeSlots { get; set; }

    }
}
