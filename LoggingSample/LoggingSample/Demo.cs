using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingSample
{
    public class Demo
    {
        private readonly ILogger<Demo> _logger;
        public Demo(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Demo>();
        }

        public void Foo()
        {
            _logger.LogInformation("Foo called, info message");
        }
        public void Bar()
        {
            _logger.LogError("some error occurred, Bar");
        }
    }
}
