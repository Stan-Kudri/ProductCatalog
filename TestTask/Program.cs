using MaterialSkin;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestTask.ChildForms.Import;
using TestTask.Core;
using TestTask.Core.Models.Modes;
using TestTask.Core.Models.Steeps;
using TestTask.Core.Models.Users;
using TestTask.Forms;
using TestTask.Forms.ModeForm;
using TestTask.Forms.StepForm;

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
                .AddScoped(e => new DbContextFactory(ConnectionName))
                .AddScoped(e => e.GetRequiredService<DbContextFactory>().Create())
                .AddScoped<IMessageBox>(e => new MessageBoxShow())
                .AddScoped<UserService>()
                .AddScoped<ModeService>()
                .AddScoped<StepService>()
                .AddScoped<UserValidator>()
                .AddSingleton<BaseForm>()
                .AddTransient<LoginForm>()
                .AddTransient<RegistrationForm>()
                .AddTransient<ImportDatabaseForm>()
                .AddTransient<TableForm>()
                .AddTransient<AddItemModeForm>()
                .AddTransient<EditItemModeForm>()
                .AddTransient<AddItemStepForm>();

            var container = collection.BuildServiceProvider();

            using (var scope = container.CreateScope())
            {
                var loginForm = scope.ServiceProvider.GetRequiredService<LoginForm>();
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(loginForm);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey800, Primary.Blue500, Accent.Indigo700, TextShade.WHITE);
                Application.Run(loginForm);
            }
        }
    }
}
