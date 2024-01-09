using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using MudBlazor.Services;
using TestTask.Core;
using TestTask.Core.Import;
using TestTask.Core.Import.Importers;
using TestTask.Core.Models;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;
using TestTask.Core.Models.Users;
using TestTask.MudBlazors.Pages.Table.Model;
using TestTask.MudBlazors.Pages.Table.PageTableProvider;
using TestTask.MudBlazors.Pages.Table.PageTableView;

const string ConnectionName = "DbConnection";

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddSingleton(e => new DbContextFactory(ConnectionName));
builder.Services.AddScoped(e => e.GetRequiredService<DbContextFactory>().Create());
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<CompanyRepository>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<CategoryRepository>();
builder.Services.AddScoped<ProductTypeRepository>();
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

builder.Services.AddScoped<CompanyDetailProvider>();
builder.Services.AddScoped<ITableDetailProvider<Company>>(e => e.GetRequiredService<CompanyDetailProvider>());
builder.Services.AddScoped<ISortEntity<Company, CompanySortType>>(e => new SortCompany());

builder.Services.AddScoped<CategoryDetailProvider>();
builder.Services.AddScoped<ITableDetailProvider<Category>>(e => e.GetRequiredService<CategoryDetailProvider>());
builder.Services.AddScoped<ISortEntity<Category, CategoriesSortType>>(e => new SortCategories());

builder.Services.AddScoped<TypeDetailProvider>();
builder.Services.AddScoped<ITableDetailProvider<ProductType>>(e => e.GetRequiredService<TypeDetailProvider>());
builder.Services.AddScoped<ISortEntity<ProductType, ProductTypeSortType>>(e => new SortType());

builder.Services.AddScoped<ProductDetailProvider>();
builder.Services.AddScoped<ITableDetailProvider<Product>>(e => e.GetRequiredService<ProductDetailProvider>());
builder.Services.AddScoped<ISortEntity<Product, ProductSortType>>(e => new SortProduct());

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