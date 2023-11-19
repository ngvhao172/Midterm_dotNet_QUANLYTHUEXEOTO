using dotNet_GK_QUANLYTHUEXEOTO.Model.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace dotNet_GK_QUANLYTHUEXEOTO
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            App.ConfigureServices();

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}