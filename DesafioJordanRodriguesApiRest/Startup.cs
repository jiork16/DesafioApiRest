using DesafioJordanRodriguesApiRest.Application.Extensions;
using DesafioJordanRodriguesApiRest.Data.Data;
using DesafioJordanRodriguesApiRest.Data.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using System.Text.Json.Serialization;


namespace DesafioJordanRodriguesApiRest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ChallengeContext>(options => options.UseNpgsql(Configuration.GetConnectionString("IdentityConnection")));
            //services.AddControllers();
            services.AddControllers().AddJsonOptions(x =>
            {
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                x.JsonSerializerOptions.MaxDepth = 256;
            }
            );
            services.AddApplicationLayer();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddPersistenceContexts();
            services.AddRepositories();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IActionContextAccessor, ActionContextAccessor>();
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            //services.AddMediatR(Assembly.GetExecutingAssembly(), typeof(IUserRepository).Assembly);
            //services.AddScoped(typeof(IUserRepository), typeof(UserRepository));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
