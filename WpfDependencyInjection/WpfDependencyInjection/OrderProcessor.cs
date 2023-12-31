using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDependencyInjection.Interfaces;

namespace WpfDependencyInjection
{
    public class OrderProcessor
    {
        private readonly ILogger _logger;
        // Property Injection
        public ILogger Logger { get; set; }


        // Constructor Injection
        public OrderProcessor(ILogger logger)
        {
            _logger = logger;
        }

        //public void ProcessOrder(string order)
        //{
        //    _logger.Log($"Processing order: {order}");
        //}

        // Method Injection
        public void ProcessOrder(string order, ILogger logger)
        {
            // Check for null to avoid null reference exception
            logger?.Log($"Processing order: {order}");
        }

        public void ProcessOrder(string order)
        {
            // Check for null to avoid null reference exception
            Logger?.Log($"Processing order: {order}");
        }

    }
}
