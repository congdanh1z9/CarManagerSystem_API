using Application.Interfaces;
using Application.Repositories;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DenpendencyInjection
    {
        public static IServiceCollection AddInfrastructuresService(this IServiceCollection services, string databaseConnection)
        {

            services.AddScoped<IAccountRepository, AccountRepository>();

            services.AddDbContext<AppDbContext>(option =>
            {
                option.UseNpgsql(databaseConnection);
            });
            services.AddAutoMapper(typeof(Mapper).Assembly);
            return services;
        }
    }
}
