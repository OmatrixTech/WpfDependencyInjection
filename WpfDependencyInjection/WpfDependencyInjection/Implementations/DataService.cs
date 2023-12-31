using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDependencyInjection.Interfaces;

namespace WpfDependencyInjection.Implementations
{
    public class DataService : IDataService
    {
        public string GetData()
        {
            return "Sample Data";
        }
    }
}
