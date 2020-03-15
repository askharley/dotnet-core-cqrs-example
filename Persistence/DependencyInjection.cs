using Application.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            // Add DbContext
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseInMemoryDatabase("cqrs-example");
            });

            services.AddScoped<DbContext, ApplicationDbContext>();
            services.AddTransient<IApplicationDbContext, ApplicationDbContext>();

            return services;
        }
    }
}