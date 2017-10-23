using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateSample
{
    class Calculator
    {
        public void Add(int x, int y) =>
            Console.WriteLine($"{x} + {y} = {x + y}");

        public void Subtract(int x, int y) =>
            Console.WriteLine($"{x} - {y} = {x - y}");
    }
}
