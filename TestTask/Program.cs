using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using TestTask.Core;
using TestTask.Core.Models.Modes;
using TestTask.Core.Models.Steeps;
using TestTask.Core.Models.Users;
using TestTask.Forms;

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
            var builder = new DbContextOptionsBuilder<AppDbContext>().UseSqlite($"Data Source={ConnectionName}.db");

            var message = new MessageBoxShow();

            using (var appDbContext = new AppDbContext(builder.Options))
            {
                appDbContext.Database.EnsureCreated();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm(new UserService(appDbContext), new ModeService(appDbContext), new StepService(appDbContext), message));

            }
        }
    }
}
