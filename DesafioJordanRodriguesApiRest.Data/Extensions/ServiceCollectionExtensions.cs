using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using DesafioJordanRodriguesApiRest.Application.Interfaces;
using DesafioJordanRodriguesApiRest.Data.Repositories;

namespace DesafioJordanRodriguesApiRest.Data.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddPersistenceContexts(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            #region Repositories
            //services.AddTransient<Application.Interfaces.Repositories.Identity.IUnitOfWork, Repositories.Identity.UnitOfWork>();
            services.AddTransient(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>));
            services.AddTransient(typeof(IUserRepository), typeof(UserRepository));

            #endregion Repositories
        }
    }
}
