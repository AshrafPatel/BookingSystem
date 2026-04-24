

using BookingSystem.Domain.Entities.Customer;
using BookingSystem.Domain.Entities.Staff;

namespace BookingSystem.Domain.Entities.Booking
{
    public class Booking
    {
        public Guid Id { get; set; }
        //Customer
        public Guid CustomerProfileId { get; set; }
        public required CustomerProfile CustomerProfile { get; set; }
        //Staff not required but added for easy navigation
        public Guid StaffProfileId { get; set; }
        public required StaffProfile StaffProfile { get; set; }
        //Service
        public Guid ServiceId { get; set; }
        public required Service.Service Service { get; set; }
        //Timeslots
        public Guid TimeSlotId { get; set; }
        public required TimeSlot TimeSlot { get; set; }
        //Booking Info
        public DateTime CreatedAt { get; set; }
        public BookingStatus Status { get; set; }
    }
}