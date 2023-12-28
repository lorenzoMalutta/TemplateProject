using BestPractices101.Entity;

namespace BestPractices101.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();

            return services;
        }
    }
}
