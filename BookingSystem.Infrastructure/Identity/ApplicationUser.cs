using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Infrastracture.Identity
{
    public class ApplicationUser : IdentityUser
    {
        //Optional properties for user profile name, Address, PhoneNumber are already included in
        //IdentityUser, so we can use them directly without adding them here
    }
}
