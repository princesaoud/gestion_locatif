using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using GestionLocativ.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddMudServices();
builder.Services.AddSingleton<AuthService>();

await builder.Build().RunAsync();
