using System.Threading.Tasks;
using BxBlazor.Services;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace blazorwasm.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("app");

            await builder.Build().RunAsync();
        }
    }
}
