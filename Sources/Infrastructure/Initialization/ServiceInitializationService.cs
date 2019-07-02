using AutoMapper;
using Lamar;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mmu.Mls3.WebApi.Infrastructure.Initialization.Servants;
using Mmu.Mls3.WebApi.Infrastructure.Settings.Models;

namespace Mmu.Mls3.WebApi.Infrastructure.Initialization
{
    internal static class ServiceInitializationService
    {
        internal static void InitializeServices(ServiceRegistry services, IConfiguration config)
        {
            services.AddAutoMapper(typeof(ServiceInitializationService).Assembly);
            services.AddControllers().AddNewtonsoftJson();
            services.Configure<AppSettings>(config.GetSection(AppSettings.SectionKey));
            InitializeCors(services);
            InitializeSecurity(services);
        }

        private static void InitializeCors(ServiceRegistry services)
        {
            services.AddCors(
                options =>
                {
                    options.AddPolicy(
                        "All",
                        builder =>
                            builder.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader());
                });
        }

        private static void InitializeSecurity(ServiceRegistry services)
        {
            AuthenticationInitializationService.Initialize(services);
            AuthorizationInitializationService.Initialize(services);
        }
    }
}