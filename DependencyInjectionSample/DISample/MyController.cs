using System;
using System.Collections.Generic;
using System.Text;

namespace DISample
{
    public class MyController
    {
        private readonly IMyService _myService;
        public MyController(IMyService myService)  // constructor injection
        {
            _myService = myService;
        }
        public string Index() => _myService.Greeting("Stephanie");
    }
}
