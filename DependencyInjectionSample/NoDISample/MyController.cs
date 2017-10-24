using System;
using System.Collections.Generic;
using System.Text;

namespace NoDISample
{
    public class MyController
    {
        public string Index() => new MyService().Greeting("Stephanie");
    }
}
