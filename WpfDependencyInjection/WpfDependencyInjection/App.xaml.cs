using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using WpfDependencyInjection.Implementations;
using WpfDependencyInjection.Interfaces;
using WpfDependencyInjection.ViewModels;

namespace WpfDependencyInjection
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
        public App()
        {
            // Set up DI container
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();
        }
        private void ConfigureServices(IServiceCollection services)
        {
            // Register services for DI
            services.AddSingleton<ILogger, ConsoleLogger>();
            services.AddSingleton<IDataService, DataService>();

            // Register views
            services.AddTransient<MainWindow>();

            // Register view models
            services.AddSingleton<MainViewModel>();
        }
    }
}
