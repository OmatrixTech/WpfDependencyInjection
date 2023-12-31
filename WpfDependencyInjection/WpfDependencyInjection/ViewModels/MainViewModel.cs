using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfDependencyInjection.Interfaces;

namespace WpfDependencyInjection.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly ILogger? logger = null;
        private readonly IDataService? _dataService = null;
        public DelegateCommand ShowDependencyCommand{get;set;}
        public MainViewModel(ILogger logger, IDataService _dataService)
        {
            this.logger = logger;
            this._dataService = _dataService;
            ShowDependencyCommand = new DelegateCommand(DependencyHandler);
        }

        private void DependencyHandler()
        {
            logger.Log("Logger Instance");
            string retResult = _dataService.GetData();
            MessageBox.Show("Data Seervice  : " + retResult);
        }
    }
}
