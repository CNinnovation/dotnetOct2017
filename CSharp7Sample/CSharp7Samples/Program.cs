using CSharp7Samples;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // BinaryLiteralsAndDigitSeparators();
        // RefLocalAndRefReturn();
        // OutVars();
        // LocalFunctions();
        LocalFunctions2();
        //LambdaExpressionsEverywhere();
       // await FlexibleAwaitAsync();
        //ThrowExpressions();
        //PatternMatching();
        //TuplesAndDeconstruction();
    }

    private static void LocalFunctions2()
    {
        int[] data = { 1, 2, 3, 4 };
        var q = data.Filter(null);

        foreach (var item in q)
        {
            Console.WriteLine(item);
        }
    }

    private static void BinaryLiteralsAndDigitSeparators()
    {
        Console.WriteLine(nameof(BinaryLiteralsAndDigitSeparators));
        int b1 = 0b0000_1111_1010_0101;
        Console.WriteLine($"{b1:X}");


        Console.WriteLine();
    }

    private static void RefLocalAndRefReturn()
    {
        Console.WriteLine(nameof(RefLocalAndRefReturn));
        int[] data = { 1, 2, 3, 4 };
        ref int a = ref GetElementByIndex(data, 2);  // a is a ref local
        a = 42;
        Console.WriteLine($"original: {data[2]}");
        Console.WriteLine($"new: {a}");

        Console.WriteLine();
    }

    public static ref int GetElementByIndex(int[] data, int index)  // ref return
    {
        //unsafe
        //{
        //    int* p = &index;
        //}

        ref int x = ref data[index];  // ref local
        return ref x;
    }


    private static void OutVars()
    {
        Console.WriteLine(nameof(OutVars));
        Console.WriteLine("enter a number:");
        string input = Console.ReadLine();
        bool success = int.TryParse(input, out int result);
        if (success)
        {
            Console.WriteLine($"this number: {result}");
        }
        else
        {
            Console.WriteLine("NaN");
        }
        Console.WriteLine();
    }

    private static void LocalFunctions()
    {
        Console.WriteLine(nameof(LocalFunctions));
        int z = 3;

        int add(int x, int y)
        {
            return x + y + z;  // using closure
        }

        // Func<int, int, int> add2 = (x, y) => x + y + z;

        int result = add(1, 2);
        Console.WriteLine($"result: {result}");

        Console.WriteLine();
    }

    private static int MyAdd(int x, int y)
    {
        return x + y;
    }

    private static void LambdaExpressionsEverywhere()
    {
        Console.WriteLine(nameof(LambdaExpressionsEverywhere));

        Console.WriteLine();
    }

    private static async Task FlexibleAwaitAsync()
    {
        Console.WriteLine(nameof(FlexibleAwaitAsync));
        int x = await GetANumberAsync();
        Console.WriteLine(x);

        Console.WriteLine();
    }

    public static ValueTask<int> GetANumberAsync()
    {
        return new ValueTask<int>(42);
//         return Task.FromResult<int>(42);
    }

    private static void ThrowExpressions()
    {
        Console.WriteLine(nameof(ThrowExpressions));
        int x = 42;

        int y = 0;
        if (x <= 42)
        {
            y = x;
        }
        else
        {
            throw new Exception("bad value");
        }

        Console.WriteLine($"y: {y}");
        Console.WriteLine();
    }

    private static void PatternMatching()
    {
        Console.WriteLine(nameof(PatternMatching));

        Console.WriteLine();
    }

    public static void IsPattern(object o)
    {

    }

    public static void SwitchPattern(object o)
    {

    }

    private static void TuplesAndDeconstruction()
    {
        Console.WriteLine(nameof(TuplesAndDeconstruction));

        Console.WriteLine();
    }




}