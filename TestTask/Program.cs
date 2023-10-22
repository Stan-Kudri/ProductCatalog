using System;
using System.Windows.Forms;
using TestTask.Core.Db;
using TestTask.Core.ImportDB.Read.Header;
using TestTask.Core.Service;
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
            new DbContextFactory().EnsureCreated(ConnectionName);
            var message = new MessageBoxShow();

            new ReadMode().Reader();
            new ReadStep().Reader();

            using (var appDbContext = new AppDbContext(ConnectionName))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm(new UserService(appDbContext), new ModeService(appDbContext), new StepService(appDbContext), message));
            }
        }
    }
}
