using WebApplication1.Interfaces;

namespace WebApplication1.Extensions
{
    public static class ServiceExtensions
    { 
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IScheduleService, ScheduleService>();
            services.AddScoped<ISubjectService, SubjectService>();

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