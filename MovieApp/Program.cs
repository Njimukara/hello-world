using Microsoft.Extensions.DependencyInjection;
using MovieApp.DataProcessing;

namespace MovieApp
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

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Building service collection and registering dependencies
            var services = new ServiceCollection();
            services.AddScoped<IDataProcessor, MovieAppDataProcessing>();
            services.AddScoped<IDataProcessor, SqlDataProcessor>();

            services.AddScoped<MovieAppDataProcessing, MovieAppDataProcessing>();
            services.AddScoped<SqlDataProcessor, SqlDataProcessor>();

            services.AddScoped<Form1>();

            // Build the service provider, Get the main form and inject dependencies into it
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form);
            }
        }
    }
}