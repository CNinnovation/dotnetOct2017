using System;

namespace SpanSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 42;
            Console.WriteLine(x.ToString());

            Foo(x);

            // ref types immer am heap
            // val types am stack oder am heap (boxing)

            // xx types only am stack
            int[] data = { 1, 2, 3, 4 };
            Span<int> span1 = new Span<int>(data);
            Span<int> span2 = span1.Slice(2);
            int x2 = span2[0];

           // span1.GetHashCode();
            // string s1 = span2.ToString();

            Person[] people = new Person[]
            {
                new Person("Tom"), new Person("Turbo")
            };
            Span<Person> span3 = new Span<Person>(people);

            Span<Person> span4 = span3.Slice(1);
            Console.WriteLine($"{span4[0].FirstName}");
            Console.WriteLine(x2);
            
        }
        static void Foo(object o)  // boxing
        {
            Console.WriteLine(o.ToString());
        }
    }
}
