using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using ProductCatalog.MudBlazors.Extension;

var builder = WebApplication.CreateBuilder(args);

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
app.Run();
