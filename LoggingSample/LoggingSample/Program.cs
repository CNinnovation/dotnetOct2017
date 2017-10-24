using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace LoggingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterServices();

            Demo d1 = Container.GetService<Demo>();
            d1.Foo();
            d1.Bar();
            
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddLogging(options =>
            {
                options.AddConsole();
                options.AddDebug();
            });
            services.AddTransient<Demo>();
            Container = services.BuildServiceProvider();
        }

        public static IServiceProvider Container { get; set; }
    }
}
