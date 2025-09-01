using System;
using System.Windows.Forms;
using MaterialSkin;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProductCatalog.WinForms.Extension;
using ProductCatalog.WinForms.Forms;
using ProductCatalog.WinForms.Model;

namespace ProductCatalog.WinForms
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using var host = CreateHostBuilder().Build();
            RunLoginForm(host.Services);
        }

        private static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((_, services) =>
                {
                    services
                        .AddDatabaseServices(ConnectionName)
                        .AddApplicationServices()
                        .AddImporterServices()
                        .AddFormServices()
                        .AddSingleton(new OpenFileDialog
                        {
                            Filter = "Excel Files|*.xlsx;*.xls;*.xlsm"
                        })
                        .AddSingleton(new SaveFileDialog
                        {
                            Filter = "Excel Files|*.xlsx;*.xls;*.xlsm"
                        })
                        .AddSingleton<ExcelImporterModel>();
                });

        private static void RunLoginForm(IServiceProvider services)
        {
            using var scope = services.CreateScope();
            var loginForm = scope.ServiceProvider.GetRequiredService<LoginForm>();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(loginForm);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            Application.Run(loginForm);
        }
    }
}
