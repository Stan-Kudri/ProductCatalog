using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using MudBlazor.Services;
using TestTask.Core;
using TestTask.Core.Import;
using TestTask.Core.Import.Importers;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;
using TestTask.Core.Models.Users;
using TestTask.MudBlazors.Model;

const string ConnectionName = "DbConnection";

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddSingleton(e => new DbContextFactory(ConnectionName));
builder.Services.AddScoped(e => e.GetRequiredService<DbContextFactory>().Create());
builder.Services.AddScoped<IMessageBox>(e => new MessageBoxMudBlazor());
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<CompanyService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<ProductTypeService>();
builder.Services.AddScoped<UserValidator>();
builder.Services.AddSingleton(e => new CompanyImporter());
builder.Services.AddSingleton(e => new ProductImporter());
builder.Services.AddSingleton(e => new ProductImporter());
builder.Services.AddSingleton(e => new CategoryImporter());
builder.Services.AddSingleton(e => new TypeProductImporter());
builder.Services.AddSingleton(e => new ExcelImporter<Company>(e.GetRequiredService<CompanyImporter>()));
builder.Services.AddSingleton(e => new ExcelImporter<Product>(e.GetRequiredService<ProductImporter>()));
builder.Services.AddSingleton(e => new ExcelImporter<Category>(e.GetRequiredService<CategoryImporter>()));
builder.Services.AddSingleton(e => new ExcelImporter<ProductType>(e.GetRequiredService<TypeProductImporter>()));

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