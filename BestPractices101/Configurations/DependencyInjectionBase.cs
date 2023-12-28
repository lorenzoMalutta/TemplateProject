using BestPractices101.Entity;

namespace BestPractices101.Configurations
{
    public static class DependencyInjectionBase
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();

            return services;
        }
    }
}
