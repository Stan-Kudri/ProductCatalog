using MaterialSkin;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestTask.ChildForms.Import;
using TestTask.Core;
using TestTask.Core.Import;
using TestTask.Core.Import.Importers;
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
                .AddSingleton(e => new DbContextFactory(ConnectionName))
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
                .AddTransient<AddItemStepForm>()
                .AddSingleton(e => new OpenFileDialog { Filter = "Excel Files |*.xlsx;*.xls;*.xlsm" })
                .AddSingleton(e => new SaveFileDialog() { Filter = "Excel Files |*.xlsx;*.xls;*.xlsm" })
                .AddSingleton(e => new ModeImporter())
                .AddSingleton(e => new StepImporter())
                .AddSingleton(e => new ExcelImporter<Mode>(e.GetRequiredService<ModeImporter>()))
                .AddSingleton(e => new ExcelImporter<Step>(e.GetRequiredService<StepImporter>()));

            var container = collection.BuildServiceProvider();

            using (var scope = container.CreateScope())
            {
                using (var loginForm = scope.ServiceProvider.GetRequiredService<LoginForm>())
                {
                    var materialSkinManager = MaterialSkinManager.Instance;
                    materialSkinManager.AddFormToManage(loginForm);
                    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey400, Primary.Grey800, Accent.Yellow700, TextShade.WHITE);
                    Application.EnableVisualStyles();
                    Application.Run(loginForm);
                }
            }
        }
    }
}
