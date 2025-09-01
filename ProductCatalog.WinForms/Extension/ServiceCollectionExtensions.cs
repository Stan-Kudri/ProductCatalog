using System;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.Core;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Import.Importers;
using ProductCatalog.Core.Models;
using ProductCatalog.Core.Models.Products;
using ProductCatalog.Core.Models.Types;
using ProductCatalog.Core.Models.Users;
using ProductCatalog.Migrations;
using ProductCatalog.WinForms.Forms;
using ProductCatalog.WinForms.Messages;
using ProductCatalog.WinForms.Model.Importer;

namespace ProductCatalog.WinForms.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabaseServices(
            this IServiceCollection services,
            string connectionName)
        {
            services.AddSingleton(_ => new DbContextFactory(connectionName))
                    .AddScoped(_ => _.GetRequiredService<DbContextFactory>().Create());

            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<UserService>()
                    .AddScoped<IPasswordHasher, BCryptPasswordHasher>()
                    .AddScoped<IUserValidator, UserValidator>()
                    .AddScoped<IMessageBox, MessageBoxShow>()
                    .AddScoped<MessageByTable<ProductType>>()
                    .AddScoped<MessageByTable<Product>>();

            return services;
        }

        public static IServiceCollection AddImporterServices(this IServiceCollection services)
        {
            services.Scan(scan => scan
                .FromAssemblies(
                    typeof(IImporter<>).Assembly,
                    typeof(ExcelImporter<>).Assembly,
                    typeof(IExcelImpoterTable).Assembly)

                    .AddClasses(t => t.AssignableTo(typeof(IImporter<>)))
                    .AsImplementedInterfaces()
                    .WithSingletonLifetime()

                    .AddClasses(t => t.AssignableTo(typeof(ExcelImporter<>)))
                    .AsSelf()
                    .WithSingletonLifetime()

                    .AddClasses(t => t.AssignableTo<IExcelImpoterTable>())
                    .AsImplementedInterfaces()
                    .WithSingletonLifetime()
                    );

            return services;
        }

        public static IServiceCollection AddFormServices(this IServiceCollection services)
        {
            services.Scan(scan => scan
                .FromAssemblies(typeof(BaseService<>).Assembly)
                    .AddClasses(t => t.AssignableTo(typeof(BaseService<>)))
                    .AsSelf()
                    .WithScopedLifetime()

                .FromAssemblies(typeof(BaseForm).Assembly)
                    .AddClasses(t => t.AssignableTo<BaseForm>())
                    .AsSelf()
                    .WithTransientLifetime()
                    );

            return services;
        }
    }
}
