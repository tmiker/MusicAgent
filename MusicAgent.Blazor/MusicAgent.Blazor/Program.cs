using Microsoft.AspNetCore.Components.Authorization;
using MusicAgent.Blazor.Auth;
using MusicAgent.Blazor.Client.Abstractions;
using MusicAgent.Blazor.Client.Pages;
using MusicAgent.Blazor.Client.Services;
using MusicAgent.Blazor.Components;
using MusicAgent.Blazor.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<AuthenticationStateProvider, PersistingAuthenticationStateProvider>();

builder.Services.AddScoped<IToastrService, ToastrService>();

// SEMANTIC KERNEL SERVICE CONFIGURATION
builder.Services.RegisterSemanticKernelServices(builder.Configuration, options =>
{
    options.ModelProvider = SemanticKernelOptions.LMStudio_Model_Provider;
});
builder.Services.AddOptions<SemanticKernelSettings>().Configure<IConfiguration>((options, config) =>
{
    config.GetSection(SemanticKernelSettings.SectionName).Bind(options);
});

// LOCAL MODEL PROVIDER SERVICES
builder.Services.RegisterLocalModelProviderServices();

// OIDC AUTHENTICATION

// AUTHORIZATION

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//app.UseAuthentication();
//app.UseAuthorization();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(MusicAgent.Blazor.Client._Imports).Assembly);

app.Run();
