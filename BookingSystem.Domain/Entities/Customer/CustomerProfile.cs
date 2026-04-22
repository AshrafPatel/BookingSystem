using BookingSystem.Infrastracture.Identity;
using System.ComponentModel.DataAnnotations;
using BookingSystem.Domain.Entities.Booking;

namespace BookingSystem.Domain.Entities.Customer
{
    public class CustomerProfile
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required ApplicationUser User { get; set; }
        public ICollection<Booking.Booking> Bookings { get; set; } = [];
    }
}
