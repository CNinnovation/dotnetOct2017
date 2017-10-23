using System;

namespace DelegateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Action<int, int> mathop = calc.Add;
            mathop += calc.Subtract;
            mathop(7, 2);

            mathop.Invoke(7, 2);
            foreach (Action<int, int> mathop1 in mathop.GetInvocationList())
            {
                mathop1(11, 3);
            }
        }
    }
}
