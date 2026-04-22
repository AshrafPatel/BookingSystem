using BookingSystem.Infrastracture.Identity;
using System.ComponentModel.DataAnnotations;


namespace BookingSystem.Domain.Entities
{
    public class StaffProfile
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required ApplicationUser User { get; set; }
        public ICollection<Booking> Bookings { get; set; } = [];
        //Timeslots belong to staff so we can easily find available timeslots for a service and book them without worrying about staff availability
        public ICollection<TimeSlot> TimeSlots { get; set; } = [];
        //Qualifications belong to staff so we can easily find staff with the required qualifications for a service and book them without worrying about staff qualifications
        public ICollection<Qualification> Qualifications { get; set; } = [];
    }
}
