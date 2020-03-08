using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using NLayersApp.Persistence;
using NLayersApp.CQRS;
using NLayersApp.Persistence.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using BackendApi.Models;
using Microsoft.EntityFrameworkCore;

[assembly: FunctionsStartup(typeof(BackendApi.Startup))]

namespace BackendApi
{
    public class Startup : FunctionsStartup
    {
        TypesResolver _resolver;
        public Startup()
        {
            _resolver = new TypesResolver(() => new[] { typeof(TestModel), typeof(Page), typeof(Section), typeof(Member), typeof(Component) });
        }

        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<ITypesResolver>(s => _resolver);

            var connectionString = "Server=192.168.1.191;Initial Catalog=bxblazor-db;User Id=sa;Password=mrullerp!0";

            builder.Services.AddDbContext<IContext, TDbContext>(c => {
                c.UseSqlServer(
                    connectionString: connectionString,
                    sqlServerOptionsAction: b =>
                    {
                        b.MigrationsAssembly("BackendApi");
                        b.EnableRetryOnFailure(3);
                    }
                );
            });
        }
    }
}
