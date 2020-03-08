using BackendApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using NLayersApp.Persistence;
using NLayersApp.Persistence.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackendApi
{
    public class TDbContextFactory : IDesignTimeDbContextFactory<TDbContext>
    {
        ITypesResolver _resolver;
        public TDbContextFactory()
        {
            _resolver = new TypesResolver(() => new[] { typeof(TestModel), typeof(Page), typeof(Section), typeof(Member), typeof(Component) });
        }
        public TDbContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=192.168.1.191;Initial Catalog=bxblazor-db;User Id=sa;Password=mrullerp!0";
            var options = new DbContextOptionsBuilder()
                .UseSqlServer(connectionString, o => o.MigrationsAssembly("BackendApi")).Options;

            return new TDbContext(options: options, _resolver);
        }
    }
}
