using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            IMyService service = new MyService();
            string message = new MyController(service).Index();
            Console.WriteLine(message);
        }
    }
}
