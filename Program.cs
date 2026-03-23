using _10._3WinformsCArs.Data;
using Microsoft.EntityFrameworkCore;
namespace _10._3WinformsCArs
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

            Records.context = new CarsContext();
            //Records.context.Database.EnsureDeleted();
            Records.context.Database.EnsureCreated();
            Records.context.Cars.Load();
            Application.Run(new Form1());
        }
    }
}
