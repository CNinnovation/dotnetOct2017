using System;

namespace NoDISample
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = new MyController().Index();
            Console.WriteLine(message);
        }
    }
}
