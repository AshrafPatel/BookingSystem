using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Domain.Entities
{
    public class StaffProfile
    {
        [Key]
        public Guid Id { get; set; }
        public string? DisplayName { get; set; } //What sort of Doctor, Therapist, etc
        public ICollection<TimeSlot>? TimeSlots { get; set; }

    }
}
