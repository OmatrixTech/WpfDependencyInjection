using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDependencyInjection.Implementations;
using WpfDependencyInjection.Interfaces;
using WpfDependencyInjection.ViewModels;

namespace WpfDependencyInjection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = App.ServiceProvider.GetRequiredService<MainViewModel>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Using Dependency Injection with Constructor Injection
            ILogger logger = new ConsoleLogger();
            OrderProcessor orderProcessor = new OrderProcessor(logger);
            //orderProcessor.ProcessOrder("12345");


            // Inject the dependency using a method
            // orderProcessor.ProcessOrder("Method injection :12345", logger);


            // Inject the dependency using property
            orderProcessor.Logger = logger;

            orderProcessor.ProcessOrder("Property :-12345");

        }
    }
}