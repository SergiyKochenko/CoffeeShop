using System.Runtime.CompilerServices;
using CoffeeShop.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Api.Extensions
{
    public static class StartupDbContextExtension
    {
        public static IServiceCollection AddDataContext(this IServiceCollection services, IConfiguration configuration) 
        {
            var connectionString = configuration.GetConnectionString(DataContext.ConnectionStringName);
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
