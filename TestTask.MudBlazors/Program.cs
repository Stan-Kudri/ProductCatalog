using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using TestTask.MudBlazors;
using TestTask.MudBlazors.Authentications;

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

builder.AppWebApplicationBuilder();

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<AuthenticationUser>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<ServiceAuthenticationProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(e => e.GetRequiredService<ServiceAuthenticationProvider>());
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();