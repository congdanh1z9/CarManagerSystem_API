using Application.Interfaces;
using Application.Services;
using System.Diagnostics;
using WebAPI.Middlewares;
using WebAPI.Services;

namespace WebAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebAPIService(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddHealthChecks();
            services.AddSingleton<GlobalExceptionMiddleware>();
            services.AddSingleton<PerformanceMiddleware>();
            services.AddSingleton<Stopwatch>();
            services.AddHttpContextAccessor();
            //services.AddFluentValidationAutoValidation();
            //services.AddFluentValidationClientsideAdapters();
            services.AddScoped<IClaimsService, ClaimsService>();
            services.AddScoped<ICurrentTime, CurrentTime>();
            return services;
        }
    }

}
