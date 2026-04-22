using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Domain.Entities.Staff
{
    public class Qualification
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
    }
}
