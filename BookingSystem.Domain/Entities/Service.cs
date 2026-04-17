using BookingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Domain.Entities
{
    public class Service
    {
        public Guid Id { get; set; }
        public ServiceType ServiceType { get; set; }
        public string Description { get; set; } = string.Empty;
        public required int DurationMinutes { get; set; }
        public decimal Price { get; set; }
    }
}
