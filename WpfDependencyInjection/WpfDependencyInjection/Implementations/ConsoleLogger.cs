using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfDependencyInjection.Interfaces;

namespace WpfDependencyInjection.Implementations
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
           MessageBox.Show(message);
        }
    }
}
