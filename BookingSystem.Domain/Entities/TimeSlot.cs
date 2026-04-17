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
        //Staff required so staff can have same timeslots scoped to them
        //This ensures that staff have timeslots that are only relevant to them.
        public required Guid StaffProfileId { get; set; }
        public required StaffProfile StaffProfile { get; set; }
        public required DateTime Start { get; set; }
        public required DateTime End { get; set; }
        //Timeslot can be booked or not, if booked it will have a booking reference, if not it will be null
        public Booking? Booking { get; set; }
    }
}
