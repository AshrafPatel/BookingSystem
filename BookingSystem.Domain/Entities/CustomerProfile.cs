using BookingSystem.Infrastracture.Identity;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Domain.Entities
{
    public class CustomerProfile
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required ApplicationUser User { get; set; }
        public ICollection<Booking> Bookings { get; set; } = [];
    }
}
