using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using Mono.WebAssembly.Interop;

namespace blazorwasm.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddScoped<IJSInProcessRuntime, MonoWebAssemblyJSRuntime>();
            builder.RootComponents.Add<App>("app");

            await builder.Build().RunAsync();
        }
    }
}
