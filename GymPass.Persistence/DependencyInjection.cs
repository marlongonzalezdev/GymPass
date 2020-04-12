using System;
using GymPass.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GymPass.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<GymPassDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("GymPassDatabase")));

            services.AddScoped<IGymPassDbContext>(provider => provider.GetService<GymPassDbContext>());

            return services;
        }
    }
}
