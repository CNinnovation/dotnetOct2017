using System;
using System.Collections.Generic;
using System.Text;

namespace DISample
{
    public class MyService : IMyService
    {
        public string Greeting(string name) => "Hello, " + name;
    }
}
