using AutoParts.Forms;
using System.Net.NetworkInformation;

namespace AutoParts
{
    internal static class Program
    {
        public static readonly ApplicationContext context = new();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            context.MainForm = new TableViewForm();
            Application.Run(context);
        }
    }
}