using System;

namespace DotnetCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MySampleLib.Demo d1 = new MySampleLib.Demo();
            string s = d1.Hello();
            Console.WriteLine(s);

            // d1.Message();  // cannot use Windows Forms

            int a = d1.StdAdd(38, 4);
            Console.WriteLine(a);
        }
    }
}
