using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace YieldSample
{
    public class HelloWorld : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return "Hello";
            yield return "World";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
