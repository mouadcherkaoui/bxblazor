using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using NLayersApp.Persistence;
using NLayersApp.CQRS.DependencyInjection;
using NLayersApp.Persistence.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using BackendApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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

            (Environment.GetEnvironmentVariable("BXBLAZOR_CONNSTR", EnvironmentVariableTarget.Process) ??
                Environment.GetEnvironmentVariable("DEVENV_BXBLAZOR_CONNSTR"))
                .pipeTo(connectionString =>
                    builder.Services.AddDbContext<IContext, TDbContext>(c => {
                        c.UseSqlServer(
                            connectionString: connectionString,
                            sqlServerOptionsAction: b =>
                            {
                                b.MigrationsAssembly("BackendApi");
                                b.EnableRetryOnFailure(3);
                            }
                        );                   
                }));
            builder.Services.AddScoped<IContext, TDbContext>();
            builder.Services.AddMediatRHandlers(_resolver);
        }
    }
}
