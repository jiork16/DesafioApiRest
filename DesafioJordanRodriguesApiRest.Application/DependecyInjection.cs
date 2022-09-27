using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DesafioJordanRodriguesApiRest.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
