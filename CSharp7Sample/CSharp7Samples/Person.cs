using System;
using System.Collections.Generic;

namespace CSharp7Samples
{
    public class Person : BindableBase
    {
        // public event EventHandler MyEvent;
        private EventHandler _myEvent;
        public event EventHandler MyEvent
        {
            add
            {
                _myEvent += value;
            }
            remove
            {
                _myEvent -= value;
            }
        }

        public void FireMyEvent() => _myEvent?.Invoke(this, new EventArgs());

        private string _firstName;
        private string _lastName;
        public Person(string name) => name.Split(' ').MoveElementsTo(out _firstName, out _lastName);


        public string FirstName => _firstName;
        public string LastName => _lastName;

        private int _age;

        public int Age
        {
            get => _age;
            set => SetProperty(ref _age, value);
        }

        //public void Deconstruct(out string first, out string last)
        //{
        //    first = _firstName;
        //    last = _lastName;
        //}
    }

    public static class StringCollectionExtension
    {
        public static void MoveElementsTo(this IList<string> coll, out string s1, out string s2)
        {
            if (coll.Count != 2) throw new ArgumentException("wrong collection count", nameof(coll));

            s1 = coll[0];
            s2 = coll[1];
        }
    }

    public static class PersonExtensions
    {
        public static void Deconstruct(this Person p, out string firstName, out string lastName,out int age)
        {
            firstName = p.FirstName;
            lastName = p.LastName;
            age = p.Age;
        }
    }
}
