using CSharp7Samples;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // BinaryLiteralsAndDigitSeparators();
        // RefLocalAndRefReturn();
        // OutVars();
        // await FlexibleAwaitAsync();
        // LocalFunctions();
        // LocalFunctions2();
        // LambdaExpressionsEverywhere();
        // ThrowExpressions();

        // TuplesAndDeconstruction();
        PatternMatching();
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

        //int add(int x, int y)
        //{
        //    return x + y + z;  // using closure
        //}

        int add(int x, int y) => x + y + z;

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
        var p1 = new Person("Katharina Nagel");
        p1.Age = 1;
        Console.WriteLine($"{p1.FirstName}, {p1.LastName}");


        p1.MyEvent += (sender, e) =>
        {
            Console.WriteLine("event fired");
        };

        p1.FireMyEvent();

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

        //int y = 0;
        //if (x <= 42)
        //{
        //    y = x;
        //}
        //else
        //{
        //    throw new Exception("bad value");
        //}

        int y = x <= 42 ? x : throw new Exception("bad value");

        Console.WriteLine($"y: {y}");
        Console.WriteLine();
    }

    public static void InitializeSomething(object o)
    {
        //if (o == null) throw new ArgumentNullException(nameof(o));
        //myField = o;
        myField = o ?? throw new ArgumentNullException(nameof(o));
    }
    private static object myField;

    private static void PatternMatching()
    {
        Console.WriteLine(nameof(PatternMatching));
        object[] data = { 42, "astring", null, new Person("Matthias Nagel"), new Person("Stephanie Nagel") };

        //foreach (var item in data)
        //{
        //    IsPattern(item);
        //}

        foreach (var item in data)
        {
            SwitchPattern(item);
        }


        Console.WriteLine();
    }

    public static void IsPattern(object o)
    {
        if (o is 42) Console.WriteLine("it's 42");  // const pattern
        if (o is null) Console.WriteLine("it's null");  // const pattern
        if (o is int i) Console.WriteLine($"it's an int with the value {i}"); // type pattern
        if (o is Person p) Console.WriteLine($"it's a person with {p.FirstName}");
        if (o is Person p1 && p1.FirstName.StartsWith("Steph")) Console.WriteLine($"it's Stephanie");
        if (o is var v) Console.WriteLine($"var pattern with type {v?.GetType().Name}"); // var pattern
    }

    public static void SwitchPattern(object o)
    {
        switch (o)
        {
            case 42:         // const pattern
                Console.WriteLine("it's 42");
                break;
            case null:
                Console.WriteLine("it's null");
                break;
            case int i:     // type pattern
                Console.WriteLine($"it's int with {i}");
                break;
            case Person p1 when p1.FirstName.StartsWith("Steph"):
                Console.WriteLine($"it's Stephanie");
                break;
            case Person p:
                Console.WriteLine($"it's a person {p.FirstName}");
                break;
            case var v:
                Console.WriteLine($"it's a var pattern");
                break;
            default:
                Console.WriteLine("was ist default?");
                break;
        }
    }

    private static void TuplesAndDeconstruction()
    {
        Console.WriteLine(nameof(TuplesAndDeconstruction));

        (string s, int n) t1 = ("magic", 42);
        Console.WriteLine(t1.s);
        Console.WriteLine(t1.n);

        var t2 = Divide(7, 2);
        Console.WriteLine(t2.result);
        Console.WriteLine(t2.remainder);
        (var res, var rem) = Divide(11, 4);
        Console.WriteLine(res);
        Console.WriteLine(rem);

        // immutable old ref tuple
        Tuple<int, int> oldTuple = Tuple.Create(1, 2);
        // oldTuple.Item1 = 42;

        // mutable new value tuple
        (int x1, int x2) newTuple = (1, 2);
        newTuple.x1 = 42;
        ValueTuple<int, int> newTuple2 = (3, 4);

        int x7 = 4;
        x7 = 7;


        var p2 = new Person("Stephanie Nagel");
        (var firstName, _, _) = p2;

        Console.WriteLine($"{firstName}");



        Console.WriteLine();
    }

    private static (int result, int remainder) Divide(int x, int y)
    {
        int res = x / y;
        int rem = x % y;
        return (res, rem);
    }




}