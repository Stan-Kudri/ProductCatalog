using System;
using System.Windows.Forms;
using MaterialSkin;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.Core;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Import.Importers;
using ProductCatalog.Core.Models;
using ProductCatalog.Core.Models.Products;
using ProductCatalog.Core.Models.Types;
using ProductCatalog.Core.Models.Users;
using ProductCatalog.Forms;
using ProductCatalog.Messages;
using ProductCatalog.Migrations;
using ProductCatalog.Model;
using ProductCatalog.Model.Importer;

namespace ProductCatalog
{
    public static class Program
    {
        private const string ConnectionName = "DbConnection";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var collection = new ServiceCollection()
                .AddSingleton(e => new DbContextFactory(ConnectionName))
                .AddScoped(e => e.GetRequiredService<DbContextFactory>().Create())
                .AddScoped<IMessageBox>(e => new MessageBoxShow())
                .AddScoped<UserService>()
                .AddScoped<IPasswordHasher, BCryptPasswordHasher>()
                .AddScoped<IUserValidator, UserValidator>()
                .AddScoped<MessageByTable<ProductType>>()
                .AddScoped<MessageByTable<Product>>()
                .AddSingleton(e => new OpenFileDialog { Filter = "Excel Files |*.xlsx;*.xls;*.xlsm" })
                .AddSingleton(e => new SaveFileDialog() { Filter = "Excel Files |*.xlsx;*.xls;*.xlsm" })
                .AddSingleton<ExcelImporterModel>()
                .Scan(scan => scan
                    .FromAssemblies(typeof(BaseService<>).Assembly)
                        .AddClasses(service => service.AssignableTo(typeof(BaseService<>)))
                        .AsSelf()
                        .WithScopedLifetime()

                    .FromAssemblies(typeof(BaseForm).Assembly)
                        .AddClasses(form => form.AssignableTo<BaseForm>())
                        .AsSelf()
                        .WithTransientLifetime()

                    .FromAssemblies(typeof(IImporter<>).Assembly, typeof(ExcelImporter<>).Assembly, typeof(IExcelImpoterTable).Assembly)

                        .AddClasses(importer => importer.AssignableTo(typeof(IImporter<>)))
                        .AsImplementedInterfaces()
                        .WithSingletonLifetime()

                        .AddClasses(importer => importer.AssignableTo(typeof(ExcelImporter<>)))
                        .AsSelf()
                        .WithSingletonLifetime()

                        .AddClasses(importer => importer.AssignableTo<IExcelImpoterTable>())
                        .AsImplementedInterfaces()
                        .WithSingletonLifetime());

            var container = collection.BuildServiceProvider();

            using (var scope = container.CreateScope())
            {
                using (var loginForm = scope.ServiceProvider.GetRequiredService<LoginForm>())
                {
                    var materialSkinManager = MaterialSkinManager.Instance;
                    materialSkinManager.AddFormToManage(loginForm);
                    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    Application.EnableVisualStyles();
                    Application.Run(loginForm);
                }
            }
        }
    }
}
