using System;
using System.Collections;
using System.Collections.Generic;

namespace YieldSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 4 };

            foreach (int item in data)
            {
                Console.WriteLine(item);
            }

            IEnumerator enumerator = data.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int item = (int)enumerator.Current;
                Console.WriteLine(item);
            }

            var hw = new HelloWorld();

            foreach (string s in hw)
            {
                Console.WriteLine(s);
            }
        }
    }
}
