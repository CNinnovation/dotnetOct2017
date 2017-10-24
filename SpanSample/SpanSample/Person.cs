using System;
using System.Collections.Generic;
using System.Text;

namespace SpanSample
{
    class Person
    {
        public Person(string name) => FirstName = name;

        public string FirstName { get; set; }
    }

    class Book
    {
        public Book(string title, string publisher)
        {
            Title = title;
            Publisher = publisher;
        }
        public string Title { get; }
        public string Publisher { get; }
    }

    // record
    //class Book(string Title, string Publisher)
    //{
    //}
    // var b = new Book("Professional C# 6", "Wrox Press");
    // var b2 = b with { Title = "Professional C# 7" }

    // non-nullable reference types
    // string? s = null; // compiler error
}
