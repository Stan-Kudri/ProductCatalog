using MaterialSkin;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestTask.Core;
using TestTask.Core.Import;
using TestTask.Core.Import.Importers;
using TestTask.Core.Models;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;
using TestTask.Core.Models.Users;
using TestTask.Forms;
using TestTask.Messages;
using TestTask.Migrations;
using TestTask.Model;
using TestTask.Model.Importer;

namespace TestTask
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
                .AddScoped<UserValidator>()
                .AddScoped<MessageByTable<ProductType>>()
                .AddScoped<MessageByTable<Product>>()
                .AddSingleton(e => new OpenFileDialog { Filter = "Excel Files |*.xlsx;*.xls;*.xlsm" })
                .AddSingleton(e => new SaveFileDialog() { Filter = "Excel Files |*.xlsx;*.xls;*.xlsm" })

                .Scan(scan => scan
                    .FromAssemblies(typeof(IRepository<>).Assembly)
                        .AddClasses(repository => repository.AssignableTo(typeof(IRepository<>)))
                        .AsSelf()
                        .WithScopedLifetime()

                    .FromAssemblies(typeof(BaseForm).Assembly)
                        .AddClasses(form => form.AssignableTo(typeof(BaseForm)))
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
                        .WithSingletonLifetime())

                .AddSingleton<ExcelImporterModel>();

            var container = collection.BuildServiceProvider();

            using (var scope = container.CreateScope())
            {
                using (var loginForm = scope.ServiceProvider.GetRequiredService<LoginForm>())
                {
                    var materialSkinManager = MaterialSkinManager.Instance;
                    materialSkinManager.AddFormToManage(loginForm);
                    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.Grey600, Primary.Cyan100, Accent.DeepPurple700, TextShade.WHITE);
                    Application.EnableVisualStyles();
                    Application.Run(loginForm);
                }
            }
        }
    }
}
