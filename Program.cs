using LawOfficeManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace LawOfficeManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using (var context = new LawOfficeContext())
            {
                context.Database.Migrate();
            }

            Application.Run(new MainForm());
        }
    }
}