using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVCSample.Services
{
    public class GreetingService : IGreetingService
    {
        private ILogger<GreetingService> _logger;
        public GreetingService(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<GreetingService>();
        }

        public string Greet(string name)
        {
            _logger.LogError("Error in Greet");
            return "Hello, " + name;
        }
    }
}
