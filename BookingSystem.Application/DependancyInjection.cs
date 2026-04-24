using BookingSystem.Application.Features.Auth.Login;
using BookingSystem.Application.Features.Auth.Logout;
using BookingSystem.Application.Features.Auth.RefreshToken;
using BookingSystem.Application.Features.Auth.Register;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Application
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            //Register Handlers, Services, Repositories etc here
            services.AddScoped<LoginHandler>();
            services.AddScoped<RegisterHandler>();
            services.AddScoped<RefreshTokenHandler>();
            services.AddScoped<LogoutHandler>();

            return services;
        }
    }
}
