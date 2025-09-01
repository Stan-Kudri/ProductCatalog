using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor;
using MudBlazor.Services;
using ProductCatalog.Core;
using ProductCatalog.Core.Export.SheetFillers;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Import.Importers;
using ProductCatalog.Core.Models;
using ProductCatalog.Core.Models.SortModel;
using ProductCatalog.Core.Models.Users;
using ProductCatalog.Migrations;
using ProductCatalog.MudBlazors.Authenticate;
using ProductCatalog.MudBlazors.Messages;
using ProductCatalog.MudBlazors.Pages.Table.Model;

namespace ProductCatalog.MudBlazors.Extension
{
    public static class ServiceCollectionExtensions
    {
        private const string ConnectionName = "DbConnection";

        /// <summary>
        /// Registers Razor Pages, Blazor Server, and MudBlazor UI services.
        /// </summary>
        public static IServiceCollection AddMudBlazorUI(this IServiceCollection services)
        {
            // Add services to the container.
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddMudServices(configuration =>
            {
                configuration.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
                configuration.SnackbarConfiguration.HideTransitionDuration = 100;
                configuration.SnackbarConfiguration.ShowTransitionDuration = 100;
                configuration.SnackbarConfiguration.VisibleStateDuration = 3000;
                configuration.SnackbarConfiguration.ShowCloseIcon = false;
                configuration.SnackbarConfiguration.ClearAfterNavigation = false;
            });

            return services;
        }

        /// <summary>
        /// Registers database context factory and DbContext.
        /// </summary>
        public static IServiceCollection AddDatabaseServices(this IServiceCollection services)
        {
            services.AddSingleton(e => new DbContextFactory(ConnectionName))
                    .AddScoped(e => e.GetRequiredService<DbContextFactory>().Create());

            return services;
        }

        /// <summary>
        /// Registers domain services, validators, and message dialogs.
        /// </summary>
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<UserService>()
                    .AddScoped<IPasswordHasher, BCryptPasswordHasher>()
                    .AddScoped<IUserValidator, UserValidator>()
                    .AddScoped<IMessageBox, MessageDialog>();

            return services;
        }

        public static IServiceCollection AddTableProviderServices(this IServiceCollection services)
        {
            services.Scan(scan => scan
                            .FromAssemblies(typeof(ITableDetailProvider<>).Assembly, typeof(ISortEntity<>).Assembly, typeof(ISheetFiller).Assembly)

                                .AddClasses(table => table.AssignableTo(typeof(ITableDetailProvider<>)))
                                .AsImplementedInterfaces()
                                .WithScopedLifetime()

                                .AddClasses(sort => sort.AssignableTo(typeof(ISortEntity<>)))
                                .AsImplementedInterfaces()
                                .WithScopedLifetime()

                                .AddClasses(sheetFiller => sheetFiller.AssignableTo<ISheetFiller>())
                                .AsSelf()
                                .WithScopedLifetime()
            );

            return services;
        }

        public static IServiceCollection AddBaseServices(this IServiceCollection services)
        {
            services.Scan(scan => scan.FromAssemblies(typeof(BaseService<>).Assembly)
                                      .AddClasses(service => service.AssignableTo(typeof(BaseService<>)))
                                      .AsSelf()
                                      .WithScopedLifetime());

            return services;
        }

        public static IServiceCollection AddImporterServices(this IServiceCollection services)
        {
            services.Scan(scan => scan
                            .FromAssemblies(typeof(IImporter<>).Assembly, typeof(ExcelImporter<>).Assembly)

                                .AddClasses(importer => importer.AssignableTo(typeof(IImporter<>)))
                                .AsImplementedInterfaces()
                                .WithSingletonLifetime()

                                .AddClasses(importer => importer.AssignableTo(typeof(ExcelImporter<>)))
                                .AsSelf()
                                .WithSingletonLifetime()
            );

            return services;
        }

        /// <summary>
        /// Registers authentication, login, and identity providers.
        /// </summary>
        public static IServiceCollection AddAuthenticationServices(this IServiceCollection services)
        {
            services.AddTransient<BlazorAppLoginService>();
            services.AddScoped<AuthenticationStateProvider, BlazorAuthStateProvider>();
            services.AddTransient<IUsersAuthenticate, UsersAuthenticateService>();
            return services;
        }
    }
}
