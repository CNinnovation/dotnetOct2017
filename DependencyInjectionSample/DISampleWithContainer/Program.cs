using DISample;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DISampleWithContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterServices();

            using (Container)
            {
                var controller = Container.GetService<MyController>();
                string message = controller.Index();
                Console.WriteLine(message);
            }
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IMyService, MyService>();
            services.AddTransient<MyController>();
            Container = services.BuildServiceProvider();
        }

        public static ServiceProvider Container { get; private set; }
    }
}
