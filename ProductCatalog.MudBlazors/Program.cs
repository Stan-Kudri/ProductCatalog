using ElectronNET.API;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using ProductCatalog.MudBlazors.Extension;

var builder = WebApplication.CreateBuilder(args);

// Electron.NET
builder.WebHost.UseElectron(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

builder.Services.AddMudBlazorUI()
                .AddDatabaseServices()
                .AddDomainServices()
                .AddBaseServices()
                .AddTableProviderServices()
                .AddImporterServices()
                .AddAuthenticationServices();

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseAppPipeline();

await app.StartAsync();

if (HybridSupport.IsElectronActive)
{
    await Electron.WindowManager.CreateWindowAsync();
}

await app.WaitForShutdownAsync();
