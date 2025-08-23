using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MusicAgent.Blazor.Client.Abstractions;
using MusicAgent.Blazor.Client.Auth;
using MusicAgent.Blazor.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<IToastrService, ToastrService>();

builder.Services.AddKeyedScoped<HttpClient>("LocalAPIClientFromWASM",
    (sp, key) =>
       new HttpClient
       {
           BaseAddress = new Uri(builder.Configuration["LocalAPIBaseAddress"] ??
                throw new Exception("LocalAPIBaseAddress is missing."))
       });

builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();



await builder.Build().RunAsync();
