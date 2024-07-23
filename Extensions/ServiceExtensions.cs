using HotelBookingAPI.Infrastructure.SQLServer.DataContext;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Infrastructure.Extensions {
    public static class ServiceExtensions {


        public static void ConfigureSQLContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


    }
}
