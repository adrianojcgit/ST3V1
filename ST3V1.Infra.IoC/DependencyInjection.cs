using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ST3V1.Domain.Interfaces;
using ST3V1.Infra.Data.Context;
using ST3V1.Infra.Data.Repository;
using System;

namespace ST3V1.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                                                        IConfiguration configuration)
        {
            string myConnection = configuration.GetConnectionString("ConnectionMySql");
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySql(myConnection);
            }, ServiceLifetime.Singleton);

            services.AddSingleton<ICommandRepository, CommandRepository>();
            return services;
        }
    }
}
