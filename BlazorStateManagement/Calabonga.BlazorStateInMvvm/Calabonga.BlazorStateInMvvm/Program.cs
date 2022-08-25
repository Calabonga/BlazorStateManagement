using System.Data;
using System.Diagnostics.Tracing;
using Calabonga.BlazorStateInMvvm;
using Calabonga.BlazorStateInMvvm.ViewModels;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<ICounterModel, CounterModel>();

await builder.Build().RunAsync();
