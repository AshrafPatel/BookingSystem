using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Domain.Entities
{
    public class CustomerProfile
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<TimeSlot>? TimeSlots { get; set; }
    }
}
