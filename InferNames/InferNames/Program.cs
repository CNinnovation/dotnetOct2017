using System;

namespace InferNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Book
            {
                Title = "Professional C#",
                Publisher = "Wrox Press"
            };

            var b2 = new
            {
                Title = b1.Title,
                Publisher = b1.Publisher
            };

            // infer members
            var b3 = new
            {
                b1.Title,
                b1.Publisher
            };

            Console.WriteLine(b3.Title);

            var t1 =
            (
                Title: b1.Title,
                Publisher: b1.Publisher
            );
            Console.WriteLine(t1.Title);

            var t2 =
            (
                b1.Title,
                b1.Publisher
            );
            Console.WriteLine(t2.Title);
        }
    }
}
