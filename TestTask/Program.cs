using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestTask.Core.Db;
using TestTask.Core.Service;
using TestTask.Core.Service.Components;
using TestTask.Message;

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
            var serviceCollection = new ServiceCollection()
                .AddSingleton(new DbContextOptionsBuilder<AppDbContext>().UseSqlite($"Data Source={ConnectionName}.db"))
                .AddSingleton(e => e.GetRequiredService<DbContextOptionsBuilder<AppDbContext>>().Options)
                .AddSingleton(e => new AppDbContext(e.GetRequiredService<DbContextOptions<AppDbContext>>()))
                .AddSingleton(e => new UserService(e.GetRequiredService<AppDbContext>()))
                .AddSingleton(e => new ModeService(e.GetRequiredService<AppDbContext>()))
                .AddSingleton(e => new StepService(e.GetRequiredService<AppDbContext>()))
                .AddScoped<IMessageBox>(e => new MessageBoxShow());

            var container = serviceCollection.BuildServiceProvider();

            using (var scope = container.CreateScope())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm(scope.ServiceProvider));
            }
        }
    }
}
