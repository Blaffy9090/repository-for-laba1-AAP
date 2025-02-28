using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using WebApplication1.Databases;
using WebApplication1.Filters;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Extensions
{
    public static class ServiceExtensions
    { 
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IScheduleService, ScheduleService>();

            return services;
        }

        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {           
            services.AddSwaggerGen(c =>
            {
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                c.IgnoreObsoleteActions();
            });

            return services;
        }
    }
}