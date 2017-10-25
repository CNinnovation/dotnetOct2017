using System;

namespace EFCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateADatabase();
        }

        private static void CreateADatabase()
        {
            using (var context = new BooksContext())
            {
                bool created = context.Database.EnsureCreated();
                Console.WriteLine($"database {created} created");

                var book = new Book { Title = "Professional C# 7", Publisher = "Wrox Press" };
                context.Books.Add(book);


                int changed = context.SaveChanges();
            }
        }
    }
}
